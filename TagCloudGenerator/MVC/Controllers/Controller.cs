using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagCloudGenerator;
using System.Windows.Forms;
using TagCloudGenerator.MVC.Controllers.Exceptions;
using TagCloudGenerator.MVC.Models;
using TagCloudGenerator.MVC.Views;
using System.IO;

namespace TagCloudGenerator.MVC.Controllers {

	public class Controller {

		/// <summary>
		/// Reference to the model component of the project.
		/// </summary>
		private Model model;
		/// <summary>
		/// Reference to the view component of the project.
		/// </summary>
		private MainView view;
		/// <summary>
		/// HashSet containing the characters considered to be separators.
		/// </summary>
		private HashSet<char> separators;
		/// <summary>
		/// HashSet containing the words considered to be common.
		/// </summary>
		private HashSet<string> commonWords;
		/// <summary>
		/// String of all possible separators.
		/// </summary>
		private const string SEPARATORS = "\t\n\r,-.!?[]\\;: /()\"*_#'~";
		/// <summary>
		/// The file name of the html output page.
		/// </summary>
		private const string TAG_CLOUD_EXTENSION = "/tagcloud.html";
		/// <summary>
		/// Location of the file containing the list of common words.
		/// </summary>
		private const string COMMON_WORDS_LOCATION = @"..\..\docs\CommonWords.txt";
		/// <summary>
		/// Location of the file containing the html header information.
		/// </summary>
		private const string HEADER_LOCATION = @"..\..\docs\html-templates\header.txt";
		/// <summary>
		/// Location of the file containing the html footer information.
		/// </summary>
		private const string FOOTER_LOCATION = @"..\..\docs\html-templates\footer.txt";
		/// <summary>
		/// Location of the file containing the CSS stying for the html page.
		/// </summary>
		private const string CSS_TEMPLATE_LOCATION = @"..\..\docs\html-templates\css-template.txt";

		/// <summary>
		/// Constructs a controller object, given a reference to the model and view component of the project.
		/// </summary>
		/// <param name="model">Reference to the project's model</param>
		/// <param name="view">Reference to the projects's view</param>
		public Controller(Model model, MainView view) {
			this.model = model;
			this.view = view;
			this.InitializeSeparators();
			this.InitializeCommonWords();
		}
		
		public void GenerateTagCloud() {
			/*
			 *  Use try/catch block to catch the re-thrown exceptions generated throughout
			 *  the course of execution. The messages will have specific messages attached 
			 *  to them. This allows useful error messages to be generated and keeps the
			 *  program from crashing.
			 */
			try {
				// Get the Text from this.view.InputFilePath and this.view.OutputFolderPath
				string inputFilePath = this.view.InputFilePath;
				string outputFolder = this.view.OutputFolder;

				// Append the output folder path with the appropriate file name
				string outputLocation = outputFolder + TAG_CLOUD_EXTENSION;

				// Retrieve the number of tags specified by the user
				int numberOfTags = GetNumberOfTags();

				// Read the input file.
				string[] inputLines = ReadInputFile(inputFilePath);

				// Parse the tags from inputLines
				this.ParseText(inputLines);
				
				// Get a sorted list of the parsed tags
				List<KeyValuePair<string, int>> sortedTags = this.SortTags(this.model.GetTags(), numberOfTags);

				// Print the html and css file 
				this.view.StatusLabel = "Loading...";
				this.PrintHeader(outputLocation, inputFilePath, numberOfTags);
				this.PrintBody(outputLocation, sortedTags, numberOfTags);
				this.PrintFooter(outputLocation);
				this.PrintCSS(outputFolder);

				this.view.StatusLabel = "Success!";
				this.model.ClearTags();

				System.Diagnostics.Process.Start(outputLocation);
			} catch (TagCloudException e) {
				this.view.StatusLabel = e.Message;
			} catch (Exception e) {
				this.view.StatusLabel = "Something went wrong, try again or select new locations.";
				String message = e.Message;
			}
		}

		/// <summary>
		/// Initializes this.separators by adding each character in the
		/// string this.Separators to the HashSet that is this.SEPARATORS.
		/// </summary>
		private void InitializeSeparators() {
			this.separators = new HashSet<char>();
			foreach (char separator in SEPARATORS) {
				this.separators.Add(separator);
			}
		}

		/// <summary>
		/// Initializes <code>this.commonWords</code> by reading the txt file located at 
		/// <code>COMMON_WORDS_LOCATION</code> and adding each word to the HashSet that 
		/// is <code>this.commonWords</code>.
		/// </summary>
		private void InitializeCommonWords() {

			this.commonWords = new HashSet<string>();
			string[] lines = File.ReadAllLines(COMMON_WORDS_LOCATION);
			foreach (string line in lines) {
				this.commonWords.Add(line);
			}
		}

		/// <summary>
		/// Reads the file at <code>location</code> and returns an array of string
		/// containing the lines of the file.
		/// </summary>
		/// <param name="location">The file path of the file to be read.</param>
		/// <returns>an array of string containing each line of the file at <code>location</code></returns>
		private string[] ReadInputFile(string location) {
			string[] lines = { };
			try {
				 lines = File.ReadAllLines(location);
			} catch (Exception e) {
				string message = e.Message;
				throw new InvalidInputFileException();
			}
			return lines;
		}

		/// <summary>
		/// Retrieves the text from <code>this.view.NumberOfTagsField</code> and, if possible,
		/// parses the string to an int32. Throws exception otherwise.
		/// </summary>
		/// <returns>The user-specified number of tags to display in the tag cloud</returns>
		private int GetNumberOfTags() {
			int numberOfTags = 0;
			try {
				numberOfTags = Int32.Parse(this.view.NumberOfWords);
			} catch (Exception e) {
				string message = e.Message;
				throw new InvalidNumberOfWordsException();
			}
			if (numberOfTags < 0) throw new InvalidNumberOfWordsException();

			return numberOfTags;
		}

		public void UpdateRemoveCommonWords(bool removeCommonWords) {
			this.model.UpdateRemoveCommonWords(removeCommonWords);
			bool isChecked = this.view.RemoveCommonWords;
			if (isChecked != removeCommonWords) {
				this.view.RemoveCommonWords = removeCommonWords;
			}
		}

		/// <summary>
		/// Parses every word in <code>lines</code> and adds them to <code>this.model.tagsDict</code>. If 
		/// <code>this.model.removeCommonWords</code> is true, then any word contained in 
		/// <code>this.commonWords</code> is omitted.
		/// </summary>
		/// <param name="lines">text to be parsed</param>
		private void ParseText(string[] lines) {
			foreach (string line in lines) {
				int index = 0;
				while (index < line.Length) {
					string word = this.GetNextWordOrSeparator(line, index);
					index += word.Length;
					word = word.ToLower();
					if (!this.separators.Contains(word[0])) {
						if (this.model.RemoveCommonWords()) {
							if (!this.commonWords.Contains(word)) {
								this.model.AddTag(word);
							}
						} else {
							this.model.AddTag(word);
						}
					}
				}
			}
		}

		/// <summary>
		/// Returns a string containing all of the consecutive separators or non-separator characters
		/// following the index position <code>start</code> in <code>line</code>.
		/// </summary>
		/// <param name="line">string to remove the next word or separator from</param>
		/// <param name="start">the index position from which to begin the search</param>
		/// <returns>a string containing the next consecutive separators or non-separator characters</returns>
		private string GetNextWordOrSeparator(string line, int start) {
			int index = start;
			bool beganAsSeparator = this.separators.Contains(line[index]);
			while (index < line.Length && this.separators.Contains(line[index]) == beganAsSeparator) {
				index++;
			}
			return line.Substring(start, index - start);
		}

		/// <summary>
		/// Returns a list containing the <code>numberOfTags</code> tags with the highest count in 
		/// <code>tagsDict</code>, sorted alphabetically.
		/// </summary>
		/// <param name="tagsDict">collection of tags and their counts</param>
		/// <param name="numberOfTags">The number of tags to return</param>
		/// <returns></returns>
		private List<KeyValuePair<string, int>> SortTags(Dictionary<string, int> tagsDict, int numberOfTags) {

			List<KeyValuePair<string, int>> tagsList = tagsDict.ToList();
			tagsList.Sort((x,y) => y.Value - x.Value);

			List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>();
			sortedList = tagsList.GetRange(0, numberOfTags);
			sortedList.Sort((x, y) => string.Compare(x.Key, y.Key));

			return sortedList;
		}

		/// <summary>
		/// Returns a StreamWriter. Used to maintain single point of control.
		/// </summary>
		/// <param name="outputLocation">Path of the output file</param>
		/// <param name="overWrite">Whether or not to overwrite the existing file</param>
		/// <returns>StreamWriter</returns>
		private StreamWriter GetOutputStream(string outputLocation, bool overWrite) {
			return new StreamWriter(@outputLocation, overWrite);
		}

		/// <summary>
		/// Prints the opening tags for the tagcloud.html file the path at <code>outputLocation</code>, 
		/// with a title displaying the number of words specified and the file name.
		/// </summary>
		/// <param name="outputLocation">Location of the file in which to output the html markup</param>
		/// <param name="fileName">File name from which the tags were parsed</param>
		/// <param name="numberOfTags">Number of tags being displayed in the tag cloud</param>
		private void PrintHeader(string outputLocation, string fileName, int numberOfTags) {
			string[] headerLines = File.ReadAllLines(HEADER_LOCATION);

			try {
				using (StreamWriter output = GetOutputStream(outputLocation, false)) {
					foreach (string line in headerLines) {
						if (line.Equals("**Insert Title**")) {
							fileName = "Top " + numberOfTags + " Words in " + this.ExtractFileName(fileName);
							output.WriteLine("            <h1 class=\"title\">" + fileName + "</h1>");
						} else {
							output.WriteLine(line);
						}
					}
				}
			} catch (Exception e) {
				string message = e.Message;
				throw new InvalidOutputFolderException();
			}

			
		}

		/// <summary>
		/// Removes the file path information from <code>file</code> and returns the file name and 
		/// extension of <code>file</code>.
		/// </summary>
		/// <param name="file">File path</param>
		/// <returns>file name and extension of <code>file</code></returns>
		private string ExtractFileName(string file) {
			int index = file.LastIndexOf('/');
			if (file.LastIndexOf('\\') > index) {
				index = file.LastIndexOf('\\');
			}

			return file.Substring(index + 1);
		}

		/// <summary>
		/// Prints the first <code>numberOfWords</code> tags in <code>sortedList</code> to 
		/// <code>outputLocation</code>, scaling their size and color according to their count.
		/// </summary>
		/// <param name="outputLocation">Location of the output file</param>
		/// <param name="sortedList">List containing the key value pairs of the tags and their counts</param>
		/// <param name="numberOfTags">number of tags to remove from <code>sortedList</code></param>
		private void PrintBody(string outputLocation, List<KeyValuePair<string, int>> sortedList, int numberOfTags) {

			try {
				using (StreamWriter output = GetOutputStream(outputLocation, true)) {
					for (int k = 0; k < numberOfTags; k++) {
						KeyValuePair<string, int> pair = sortedList[k];
						string tag = pair.Key;
						int count = pair.Value;
						int fontSize = this.ScaleFontSize(count);
						string hexColor = this.GetColor(count);
						/*
						 * Use a <span> element to set the properties of individual words
						 * (namely the size and color) in the parent <p> element. (The
						 * leading spaces are there to make the actual html a little more
						 * readable.
						 */
						string spanTag = "               <span style=\"color:" + hexColor
								+ ";font-size:" + fontSize + "px;\" title=\"count = "
								+ count + "\">" + tag + "</span>";
						output.WriteLine(spanTag);
					}
				}
			} catch (Exception e) {
				string message = e.Message;
				throw new Exception("Something went wrong, please Reset or pick different locations.");
			}

		}

		/// <summary>
		/// Prints the closing tags for the tagcloudl.html file to <code>outputLocation</code>.
		/// </summary>
		/// <param name="outputLocation">Location to output the closing tags</param>
		private void PrintFooter(string outputLocation) {
			string[] footerLines = File.ReadAllLines(FOOTER_LOCATION);

			try {
				using (StreamWriter output = this.GetOutputStream(outputLocation, true)) {
					foreach (string line in footerLines) {
						output.WriteLine(line);
					}
				}
			} catch (Exception e) {
				string message = e.Message;
				throw new Exception("Something went wrong, please Reset or pick different locations.");
			}
			
		}

		/// <summary>
		/// Prints the CSS file for tagcloud.html to <code>outputLocation</code>.
		/// </summary>
		/// <param name="outputLocation">Location to output CSS file</param>
		private void PrintCSS(string outputLocation) {
			string[] cssLines = File.ReadAllLines(CSS_TEMPLATE_LOCATION);

			try {
				using (StreamWriter output = this.GetOutputStream(outputLocation + "/tagcloud.css", true)) {
					foreach (string line in cssLines) {
						output.WriteLine(line);
					}
				}
			} catch (Exception e) {
				string message = e.Message;
				throw new Exception("Something went wrong, please Reset or pick different locations.");
			}
			
		}

		/// <summary>
		/// Returns an int specifying the font size of a tag, given its count.
		/// </summary>
		/// <param name="count">Count of the tag</param>
		/// <returns>Font size of a tag, given its count</returns>
		private int ScaleFontSize(int count) {

			int lowestFrequency = this.model.GetTags().Min(x => x.Value);
			/*
			 * Calculate the font size proportional to tag frequency. To
			 * accomplish proper scaling for the font sizes, Scale them
			 * proportionate to the word that occurs least frequently. For
			 * example, if "and" appears 300 times, and lowest frequency is 100,
		     * then "and" would be scaled to 215. Not a perfect solution, but it
			 * works.
			 */
			int fontSize = 15 + (count - lowestFrequency) * 5;

			/**
			 * Additional layer of scaling according to the size of the tagsMap:
			 * it seems logical that the larger the number of tags in the map,
			 * the larger their counts will likely be (in theory). Therefore
			 * scaling down incrementally should keep the font sizes from
			 * growing too fast.
			 */
			int numberOfTags = this.model.GetTags().Count;
			if (numberOfTags > 1000) {
				fontSize /= (numberOfTags / 1000);
			} else if (numberOfTags > 500) {
				fontSize /= (numberOfTags / 500);
			} else if (numberOfTags > 250) {
				fontSize /= (numberOfTags / 250);
			} else if (numberOfTags > 100) {
				fontSize /= (numberOfTags / 100);
			}
			/*
			 * Very large files tend to create ridiculously large fonts and
			 * ridiculously small fonts for lower order tags, so it's best to
			 * cap it at a certain value. This in conjunction with the scaling
			 * done previously seems to be sufficient for most cases, barring
			 * extremely large files.
			 */
			int maxFontSize = 300;
			if (fontSize > maxFontSize) {
				fontSize = maxFontSize;
			} else if (fontSize < 15) {
				fontSize = 15;
			}

			return fontSize;
		}

		/// <summary>
		/// Generates a string representing the html hex value of a color, calculated according to its count.
		/// </summary>
		/// <param name="count">Count of a tag</param>
		/// <returns>string representation of a hex color for html</returns>
		private string GetColor(int count) {

			/*
			 * The default color is black (#000000) for tags that appear once.
			 * For anything else, increment the hex value proportional to the
			 * frequency of the tag. Multiplied by 50,000 to increase color
			 * distribution.
			 */
			int color = 0x000000;
			/*
			 * If the tag appears more than once, increment its hex color value.
			 * It just looks nice with small black tags next to the colored
			 * ones. Not checking for greater than 1 occurrence would mean that
			 * all of the tags' color get incremented, and thus none of them
			 * would be black
			 */
			if (count > 1) {
				color += count * 50000;
			}
			// Convert the hexadecimal to a properly formatted string
			string hexColor = string.Format("#{0}", color.ToString("X6"));

			return hexColor;
		}

		public void Reset() {
			this.model.Reset();
			this.view.Reset();
		}

		public string ValidateInputs(string inputPath, string outputFolder, string numberOfWords) {

			if (!File.Exists(inputPath)) {
				throw new InvalidInputFileException();
			}
			if (!Directory.Exists(outputFolder)) {
				throw new InvalidOutputFolderException();
			}
			int temp = 0;
			if (!numberOfWords.Equals("")) {

				if (Int32.TryParse(numberOfWords, out temp)) {
					if (temp < 0) {
						throw new InvalidNumberOfWordsException("Number of words must be a positive integer");
					}
				} else {
					throw new InvalidNumberOfWordsException();
				}
			} else {
				throw new BlankFieldException("You must enter the number of words to display");
			}
			throw new Exception("All inputs are valid!");
		}

	}
}







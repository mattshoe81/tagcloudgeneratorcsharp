using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagCloudGenerator.MVC.Models {
	interface IModel {

		/// <summary>
		/// Returns a <code>dictionary</code> of <code>(string, int)</code> in which 
		/// each key is a unique tag read from the text and the value is the number of
		/// times that key appears in the text.
		/// </summary>
		/// <returns>A dictionary holding the tags and their counts</returns>
		Dictionary<string, int> GetTags();

		/// <summary>
		/// Updates the model's boolean representation of the user's choice of whether 
		/// or not to include common words in the list of tags generated in the tag
		/// cloud.
		/// </summary>
		/// <param name="removeCommonWords"> boolean value indicating whether or not to remove common words from the tag cloud</param>
		void UpdateRemoveCommonWords(bool removeCommonWords);

		/// <summary>
		/// Returns the model's current value for whether or not to remove common words from the
		/// tag cloud.
		/// </summary>
		/// <returns>boolean indicating whether or not common words are removed from tag cloud</returns>
		bool RemoveCommonWords();

		/// <summary>
		/// Adds <code>tag</code> to the dictionary of tags, incrementing the key's value if already in the dictionary,
		/// and adding it to the dictionary with value 1 otherwise.
		/// </summary>
		/// <param name="tag"></param>
		void AddTag(string tag);

		/// <summary>
		/// Re-initializes the dictionary containing the tags to an empty dictionary of <code>(string, int)</code>.
		/// </summary>
		void ClearTags();

		/// <summary>
		/// Resets the model to its initial state where the tags dictionary is empty and the choice to remove
		/// common words is true.
		/// </summary>
		void Reset();
	}
}

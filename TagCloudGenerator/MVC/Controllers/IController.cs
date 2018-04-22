using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagCloudGenerator.MVC.Controllers {
	interface IController {

		/// <summary>
		/// This method serves as a sort of "Main" method for the Controller class. It orchestrates 
		/// the execution of the class.
		/// </summary>
		void GenerateTagCloud();

		/// <summary>
		/// Passes <code>this.view.RemoveCommonWords.Checked</code> to the model to update 
		/// <code>this.model.RemoveCommonWords</code> to match user specification.
		/// </summary>
		/// <param name="removeCommonWords">New truth value of <code>this.model.RemoveCommonWords</code></param>
		void UpdateRemoveCommonWords(bool removeCommonWords);

		/// <summary>
		/// Resets the model and view to its initial state, clearing any existing data.
		/// </summary>
		void Reset();

		/// <summary>
		/// Returns an exception with a message describing the validity of the given inputs.
		/// </summary>
		/// <param name="inputPath"></param>
		/// <param name="outputFolder"></param>
		/// <param name="numberOfWords"></param>
		string ValidateInputs(string inputPath, string outputFolder, string numberOfWords);
	}
}

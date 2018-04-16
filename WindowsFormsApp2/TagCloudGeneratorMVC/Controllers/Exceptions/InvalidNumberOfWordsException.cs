using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TagCloudGeneratorMVC.Controllers.Exceptions {
	class InvalidNumberOfWordsException : Exception {

		public InvalidNumberOfWordsException()
			: base("Invalid number of words. Please enter a positive integer") { }

		public InvalidNumberOfWordsException(string message)
			: base(message) { }

		public InvalidNumberOfWordsException(string message, Exception inner)
			: base(message, inner) { }
	}
}

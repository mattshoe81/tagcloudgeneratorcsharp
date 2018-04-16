using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TagCloudGeneratorMVC.Controllers.Exceptions {
	public class InvalidInputFileException : Exception {

		public InvalidInputFileException()
			: base("Invalid input file") { }

		public InvalidInputFileException(string message)
			: base(message) { }

		public InvalidInputFileException(string message, Exception inner)
			: base(message, inner) { }
	}
}

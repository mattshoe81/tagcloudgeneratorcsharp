using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagCloudGenerator.MVC.Controllers.Exceptions {
	public class InvalidInputFileException : Exception {

		public InvalidInputFileException()
			: base("Invalid input file") { }

		public InvalidInputFileException(string message)
			: base(message) { }

		public InvalidInputFileException(string message, Exception inner)
			: base(message, inner) { }
	}
}

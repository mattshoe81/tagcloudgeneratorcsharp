using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagCloudGenerator.MVC.Controllers.Exceptions {
	class InvalidOutputFolderException : Exception {

		public InvalidOutputFolderException()
			: base("Invalid output folder") { }

		public InvalidOutputFolderException(string message)
			: base(message) { }

		public InvalidOutputFolderException(string message, Exception inner)
			: base(message, inner) { }
	}
}

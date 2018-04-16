using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TagCloudGeneratorMVC.Controllers.Exceptions {
	class BlankFieldException : Exception {

		public BlankFieldException() 
			:base() { }

		public BlankFieldException(string message)
			: base(message) { }

		public BlankFieldException(string message, Exception inner)
			: base(message, inner) { }
	}
}

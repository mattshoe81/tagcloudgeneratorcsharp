using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagCloudGenerator.MVC.Controllers.Exceptions {
	class BlankFieldException : Exception {

		public BlankFieldException() 
			:base() { }

		public BlankFieldException(string message)
			: base(message) { }

		public BlankFieldException(string message, Exception inner)
			: base(message, inner) { }
	}
}

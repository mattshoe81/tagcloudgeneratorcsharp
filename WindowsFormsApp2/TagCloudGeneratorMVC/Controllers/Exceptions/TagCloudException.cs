﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TagCloudGeneratorMVC.Models {
	public class TagCloudException : Exception {

		public TagCloudException() {}

		public TagCloudException(string message) 
			:base(message) {
		}

		public TagCloudException(string message, Exception inner)
			:base(message, inner) {
		}



	}
}

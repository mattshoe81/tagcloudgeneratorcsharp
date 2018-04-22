using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagCloudGenerator.MVC.Models {
	public class Model : IModel {

		private Dictionary<string, int> tagsDict;

		private bool removeCommonWords;

		public Model() {
			this.CreateNewModel();
		}

		private void CreateNewModel() {
			this.tagsDict = new Dictionary<string, int>();
			this.removeCommonWords = true;
		}

		public Dictionary<string, int> GetTags() {
			return this.tagsDict;
		}

		public void UpdateRemoveCommonWords(bool removeCommonWords) {
			this.removeCommonWords = removeCommonWords;
		}

		public bool RemoveCommonWords() {
			return this.removeCommonWords;
		}

		public void AddTag(string tag) {
			if (this.tagsDict.ContainsKey(tag)) {
				this.tagsDict[tag]++;
			} else {
				this.tagsDict.Add(tag, 1);
			}
		}

		public void ClearTags() {
			this.tagsDict = new Dictionary<string, int>();
		}

		public void Reset() {
			this.CreateNewModel();
		}
	}
}

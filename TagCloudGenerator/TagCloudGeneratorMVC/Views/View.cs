﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagCloudGenerator.ControllerNS;
using WindowsFormsApp2.TagCloudGeneratorMVC.Views;

namespace TagCloudGenerator {
	public partial class View : Form {

		private Controller controller;

		public View() {
			InitializeComponent();
		}

		public void RegisterObserver(Controller controller) {
			this.controller = controller;
		}

		private void generateButton_Click(object sender, EventArgs e) {
			this.controller.GenerateTagCloud();
		}

		public void Reset() {
			this.inputFilePath.Text = "";
			this.outputFolderPath.Text = "";
			this.numberOfWordsField.Text = "";
			this.removeCommonWordsButton.Checked = true;
			this.statusLabel.Text = "Ready!";
		}

		private void ShowFileDialog(object sender, EventArgs e) {			
			DialogResult result = this.openFileDialog.ShowDialog();
			if (result == DialogResult.OK) {
				this.inputFilePath.Text = this.openFileDialog.FileName;
			}
		}

		private void ShowFolderDialog(object sender, EventArgs e) {
			DialogResult result = this.folderBrowserDialog.ShowDialog();
			if (result == DialogResult.OK) {
				this.outputFolderPath.Text = this.folderBrowserDialog.SelectedPath;
			}
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
			this.ShowFileDialog(sender, e);
		}

		private void HowToMenuItem_Click(object sender, EventArgs e) {


		}

		private void RemoveCommonWordsButton_CheckedChanged(object sender, EventArgs e) {
			RadioButton button = (RadioButton)sender;
			if (button.Checked) {
				button.Checked = false;
			} else {
				button.Checked = true;
			}
			this.controller.UpdateRemoveCommonWords(button.Checked);
		}

		private void RemoveCommonWordsButton_CheckedChanged_1(object sender, EventArgs e) {
			CheckBox checkBox = (CheckBox)sender;
			this.controller.UpdateRemoveCommonWords(checkBox.Checked);
		}

		private void howToToolStripMenuItem_Click(object sender, EventArgs e) {
			HowToWindow window = new HowToWindow();
			window.Show();
		}

		private void validateInputsToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				this.controller.ValidateInputs(this.inputFilePath.Text, this.outputFolderPath.Text, this.numberOfWordsField.Text);

			} catch (Exception exception) {
				this.statusLabel.Text = exception.Message;
			}
		}


		public System.Windows.Forms.TextBox GetInputFilePath() {
			return this.inputFilePath;
		}

		public System.Windows.Forms.TextBox GetOutputFolder() {
			return this.outputFolderPath;
		}

		public System.Windows.Forms.CheckBox getRemoveCommonWordsButton() {
			return this.removeCommonWordsButton;
		}

		public void UpdateStatusLabel(string text) {
			this.statusLabel.Text = text;
			this.statusLabel.Refresh();
		}

		public System.Windows.Forms.OpenFileDialog GetFileDialog() {
			return this.openFileDialog;
		}


		public System.Windows.Forms.FolderBrowserDialog GetFolderBrowser() {
			return this.folderBrowserDialog;
		}

		public System.Windows.Forms.TextBox GetNumberOfWordsField() {
			return this.numberOfWordsField;
		}

		public System.Windows.Forms.Label GetStatusLabel() {
			return this.statusLabel;
		}

		private void ResetButton_Click(object sender, EventArgs e) {
			this.controller.Reset();
		}

		public string InputFilePath {
			get { return this.inputFilePath.Text; }
			set { this.inputFilePath.Text = value; }
		}
	}
}
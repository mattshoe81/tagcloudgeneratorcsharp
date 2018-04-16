namespace TagCloudGenerator {
	partial class View {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.browseInputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.browseOutputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.validateInputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.inputFilePath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.outputFolderPath = new System.Windows.Forms.TextBox();
			this.resetButton = new System.Windows.Forms.Button();
			this.generateButton = new System.Windows.Forms.Button();
			this.statusLabel = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.fileDialogButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.numberOfWordsField = new System.Windows.Forms.TextBox();
			this.removeCommonWordsButton = new System.Windows.Forms.CheckBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.howToToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1050, 49);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseInputMenuItem,
            this.browseOutputMenuItem,
            this.validateInputsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// BrowseInputMenuItem
			// 
			this.browseInputMenuItem.Name = "BrowseInputMenuItem";
			this.browseInputMenuItem.Size = new System.Drawing.Size(436, 46);
			this.browseInputMenuItem.Text = "Browse Input Files";
			this.browseInputMenuItem.Click += new System.EventHandler(this.ShowFileDialog);
			// 
			// BrowseOutputMenuItem
			// 
			this.browseOutputMenuItem.Name = "BrowseOutputMenuItem";
			this.browseOutputMenuItem.Size = new System.Drawing.Size(436, 46);
			this.browseOutputMenuItem.Text = "Browse Output Folders";
			this.browseOutputMenuItem.Click += new System.EventHandler(this.ShowFolderDialog);
			// 
			// validateInputsToolStripMenuItem
			// 
			this.validateInputsToolStripMenuItem.Name = "validateInputsToolStripMenuItem";
			this.validateInputsToolStripMenuItem.Size = new System.Drawing.Size(436, 46);
			this.validateInputsToolStripMenuItem.Text = "Validate Inputs";
			this.validateInputsToolStripMenuItem.Click += new System.EventHandler(this.validateInputsToolStripMenuItem_Click);
			// 
			// howToToolStripMenuItem
			// 
			this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
			this.howToToolStripMenuItem.Size = new System.Drawing.Size(151, 45);
			this.howToToolStripMenuItem.Text = "How To...";
			this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Input File Path:";
			// 
			// InputFilePath
			// 
			this.inputFilePath.Location = new System.Drawing.Point(283, 66);
			this.inputFilePath.Name = "InputFilePath";
			this.inputFilePath.Size = new System.Drawing.Size(533, 38);
			this.inputFilePath.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Output Folder:";
			// 
			// OutputFolderPath
			// 
			this.outputFolderPath.Location = new System.Drawing.Point(283, 146);
			this.outputFolderPath.Name = "OutputFolderPath";
			this.outputFolderPath.Size = new System.Drawing.Size(533, 38);
			this.outputFolderPath.TabIndex = 4;
			// 
			// ResetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(244, 415);
			this.resetButton.Name = "ResetButton";
			this.resetButton.Size = new System.Drawing.Size(231, 62);
			this.resetButton.TabIndex = 6;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// GenerateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(565, 415);
			this.generateButton.Name = "GenerateButton";
			this.generateButton.Size = new System.Drawing.Size(231, 62);
			this.generateButton.TabIndex = 7;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// StatusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel.Location = new System.Drawing.Point(12, 329);
			this.statusLabel.MaximumSize = new System.Drawing.Size(200, 0);
			this.statusLabel.MinimumSize = new System.Drawing.Size(1000, 0);
			this.statusLabel.Name = "StatusLabel";
			this.statusLabel.Size = new System.Drawing.Size(1000, 47);
			this.statusLabel.TabIndex = 8;
			this.statusLabel.Text = "Ready";
			this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// OpenFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// FileDialogButton
			// 
			this.fileDialogButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.fileDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileDialogButton.Location = new System.Drawing.Point(839, 52);
			this.fileDialogButton.Name = "FileDialogButton";
			this.fileDialogButton.Size = new System.Drawing.Size(159, 65);
			this.fileDialogButton.TabIndex = 9;
			this.fileDialogButton.Text = "Browse";
			this.fileDialogButton.UseVisualStyleBackColor = true;
			this.fileDialogButton.Click += new System.EventHandler(this.ShowFileDialog);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(839, 137);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 65);
			this.button1.TabIndex = 10;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ShowFolderDialog);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(242, 32);
			this.label3.TabIndex = 11;
			this.label3.Text = "Number of Words:";
			// 
			// NumberOfWordsField
			// 
			this.numberOfWordsField.Location = new System.Drawing.Point(283, 227);
			this.numberOfWordsField.Name = "NumberOfWordsField";
			this.numberOfWordsField.Size = new System.Drawing.Size(170, 38);
			this.numberOfWordsField.TabIndex = 12;
			// 
			// RemoveCommonWordsButton
			// 
			this.removeCommonWordsButton.AutoSize = true;
			this.removeCommonWordsButton.Checked = true;
			this.removeCommonWordsButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.removeCommonWordsButton.Location = new System.Drawing.Point(540, 226);
			this.removeCommonWordsButton.Name = "RemoveCommonWordsButton";
			this.removeCommonWordsButton.Size = new System.Drawing.Size(367, 36);
			this.removeCommonWordsButton.TabIndex = 13;
			this.removeCommonWordsButton.Text = "Remove Common Words";
			this.removeCommonWordsButton.UseVisualStyleBackColor = true;
			this.removeCommonWordsButton.CheckedChanged += new System.EventHandler(this.RemoveCommonWordsButton_CheckedChanged_1);
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 501);
			this.Controls.Add(this.removeCommonWordsButton);
			this.Controls.Add(this.numberOfWordsField);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.fileDialogButton);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.outputFolderPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inputFilePath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "View";
			this.Text = "Tag Cloud Generator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion






		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem browseInputMenuItem;
		private System.Windows.Forms.ToolStripMenuItem browseOutputMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputFilePath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox outputFolderPath;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button fileDialogButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox numberOfWordsField;
		private System.Windows.Forms.CheckBox removeCommonWordsButton;
		private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem validateInputsToolStripMenuItem;
	}

	

	
}


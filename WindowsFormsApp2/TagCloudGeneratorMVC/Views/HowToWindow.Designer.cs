namespace WindowsFormsApp2.TagCloudGeneratorMVC.Views {
	partial class HowToWindow {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(345, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(388, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tag Cloud Generator";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(87, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(544, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Thank you for using Tag Cloud Generator!";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(132, 178);
			this.label3.MaximumSize = new System.Drawing.Size(800, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(799, 96);
			this.label3.TabIndex = 2;
			this.label3.Text = "Simply enter the absolute path of the .txt file you\'d like to generate, or use th" +
    "e \"Browse\" button to open the file in the file explorer.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(87, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 32);
			this.label4.TabIndex = 3;
			this.label4.Text = "1.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(87, 297);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 32);
			this.label5.TabIndex = 5;
			this.label5.Text = "2.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(132, 297);
			this.label6.MaximumSize = new System.Drawing.Size(800, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(793, 96);
			this.label6.TabIndex = 4;
			this.label6.Text = "Enter the absolute path to the folder in which you\'d like to generate the .html f" +
    "ile, or use the \"Browse\" button to open the folder explorer.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(87, 415);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 32);
			this.label7.TabIndex = 7;
			this.label7.Text = "3.";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(132, 415);
			this.label8.MaximumSize = new System.Drawing.Size(800, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(796, 96);
			this.label8.TabIndex = 6;
			this.label8.Text = " Enter the number of words you\'d like to generate. The Tag Cloud Generator will g" +
    "enerate a tag cloud with that many tags with the highest count, sorted alphabeti" +
    "cally.";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(87, 533);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 32);
			this.label9.TabIndex = 9;
			this.label9.Text = "4.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(132, 533);
			this.label10.MaximumSize = new System.Drawing.Size(800, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(799, 96);
			this.label10.TabIndex = 8;
			this.label10.Text = "If you\'d like to include or exclude common words, such as \"the\" or \"and\" (among o" +
    "thers), then just check the box to indicate your choice.";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(418, 683);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 64);
			this.button1.TabIndex = 10;
			this.button1.Text = "Got It!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HowToWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1020, 812);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "HowToWindow";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
			this.Text = "How to use Tag Cloud Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button1;
	}
}
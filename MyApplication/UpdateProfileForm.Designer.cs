namespace MyApplication
{
	partial class UpdateProfileForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.FullNameTextBox = new System.Windows.Forms.TextBox();
			this.FullNameLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Location = new System.Drawing.Point(12, 41);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
			this.DescriptionLabel.TabIndex = 2;
			this.DescriptionLabel.Text = "&Description";
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DescriptionTextBox.Location = new System.Drawing.Point(78, 38);
			this.DescriptionTextBox.Multiline = true;
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DescriptionTextBox.Size = new System.Drawing.Size(320, 197);
			this.DescriptionTextBox.TabIndex = 3;
			// 
			// FullNameTextBox
			// 
			this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FullNameTextBox.Location = new System.Drawing.Point(78, 12);
			this.FullNameTextBox.Name = "FullNameTextBox";
			this.FullNameTextBox.Size = new System.Drawing.Size(320, 20);
			this.FullNameTextBox.TabIndex = 1;
			// 
			// FullNameLabel
			// 
			this.FullNameLabel.AutoSize = true;
			this.FullNameLabel.Location = new System.Drawing.Point(12, 15);
			this.FullNameLabel.Name = "FullNameLabel";
			this.FullNameLabel.Size = new System.Drawing.Size(54, 13);
			this.FullNameLabel.TabIndex = 0;
			this.FullNameLabel.Text = "&Full Name";
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(323, 241);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "&Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// UpdateProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 276);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.DescriptionLabel);
			this.Controls.Add(this.DescriptionTextBox);
			this.Controls.Add(this.FullNameTextBox);
			this.Controls.Add(this.FullNameLabel);
			this.Name = "UpdateProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UpdateProfileForm";
			this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.TextBox DescriptionTextBox;
		private System.Windows.Forms.TextBox FullNameTextBox;
		private System.Windows.Forms.Label FullNameLabel;
		private System.Windows.Forms.Button SaveButton;
	}
}
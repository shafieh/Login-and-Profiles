namespace MyApplication
{
    partial class PasswordChange
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
            this.OldPasswordLable = new System.Windows.Forms.Label();
            this.NewPasswordLable = new System.Windows.Forms.Label();
            this.ConfirmNewPasswordLable = new System.Windows.Forms.Label();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmePasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldPasswordLable
            // 
            this.OldPasswordLable.AutoSize = true;
            this.OldPasswordLable.Location = new System.Drawing.Point(6, 24);
            this.OldPasswordLable.Name = "OldPasswordLable";
            this.OldPasswordLable.Size = new System.Drawing.Size(84, 13);
            this.OldPasswordLable.TabIndex = 0;
            this.OldPasswordLable.Text = "&Old Password";
            this.OldPasswordLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewPasswordLable
            // 
            this.NewPasswordLable.AutoSize = true;
            this.NewPasswordLable.Location = new System.Drawing.Point(6, 50);
            this.NewPasswordLable.Name = "NewPasswordLable";
            this.NewPasswordLable.Size = new System.Drawing.Size(89, 13);
            this.NewPasswordLable.TabIndex = 2;
            this.NewPasswordLable.Text = "&New Password";
            // 
            // ConfirmNewPasswordLable
            // 
            this.ConfirmNewPasswordLable.AutoSize = true;
            this.ConfirmNewPasswordLable.Location = new System.Drawing.Point(6, 76);
            this.ConfirmNewPasswordLable.Name = "ConfirmNewPasswordLable";
            this.ConfirmNewPasswordLable.Size = new System.Drawing.Size(111, 13);
            this.ConfirmNewPasswordLable.TabIndex = 4;
            this.ConfirmNewPasswordLable.Text = "&Confirm Password";
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordTextBox.Location = new System.Drawing.Point(119, 21);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.Size = new System.Drawing.Size(224, 21);
            this.OldPasswordTextBox.TabIndex = 1;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(119, 47);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(224, 21);
            this.NewPasswordTextBox.TabIndex = 3;
            // 
            // ConfirmePasswordTextBox
            // 
            this.ConfirmePasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmePasswordTextBox.Location = new System.Drawing.Point(119, 73);
            this.ConfirmePasswordTextBox.Name = "ConfirmePasswordTextBox";
            this.ConfirmePasswordTextBox.Size = new System.Drawing.Size(224, 21);
            this.ConfirmePasswordTextBox.TabIndex = 5;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(150, 115);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(83, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Con&firm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 156);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ConfirmePasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.ConfirmNewPasswordLable);
            this.Controls.Add(this.NewPasswordLable);
            this.Controls.Add(this.OldPasswordLable);
            this.MinimumSize = new System.Drawing.Size(374, 195);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPasswordLable;
        private System.Windows.Forms.Label NewPasswordLable;
        private System.Windows.Forms.Label ConfirmNewPasswordLable;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmePasswordTextBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}
namespace PasswordGeneratorPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLength = new System.Windows.Forms.TextBox();
            this.CharacterSet = new System.Windows.Forms.TextBox();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.CharacterSetLabel = new System.Windows.Forms.Label();
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(355, 120);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(90, 28);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GenerateButton_Clicked);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.Location = new System.Drawing.Point(150, 62);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.ReadOnly = true;
            this.PasswordBox.Size = new System.Drawing.Size(500, 26);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.WordWrap = false;
            // 
            // PasswordLength
            // 
            this.PasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PasswordLength.ForeColor = System.Drawing.Color.White;
            this.PasswordLength.Location = new System.Drawing.Point(340, 186);
            this.PasswordLength.MaxLength = 3;
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(120, 26);
            this.PasswordLength.TabIndex = 3;
            this.PasswordLength.Text = "20";
            this.PasswordLength.WordWrap = false;
            this.PasswordLength.TextChanged += new System.EventHandler(this.PasswordLength_TextChanged);
            // 
            // CharacterSet
            // 
            this.CharacterSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.CharacterSet.ForeColor = System.Drawing.Color.White;
            this.CharacterSet.Location = new System.Drawing.Point(250, 250);
            this.CharacterSet.MaxLength = 500;
            this.CharacterSet.Multiline = true;
            this.CharacterSet.Name = "CharacterSet";
            this.CharacterSet.Size = new System.Drawing.Size(300, 100);
            this.CharacterSet.TabIndex = 4;
            this.CharacterSet.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!|%@#*$_+=";
            this.CharacterSet.TextChanged += new System.EventHandler(this.CharacterSet_TextChanged);
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(355, 415);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(90, 28);
            this.DefaultButton.TabIndex = 5;
            this.DefaultButton.Text = "Default";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Clicked);
            // 
            // CharacterSetLabel
            // 
            this.CharacterSetLabel.AutoSize = true;
            this.CharacterSetLabel.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CharacterSetLabel.ForeColor = System.Drawing.Color.White;
            this.CharacterSetLabel.Location = new System.Drawing.Point(134, 290);
            this.CharacterSetLabel.Name = "CharacterSetLabel";
            this.CharacterSetLabel.Size = new System.Drawing.Size(110, 20);
            this.CharacterSetLabel.TabIndex = 6;
            this.CharacterSetLabel.Text = "Character Set: ";
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.AutoSize = true;
            this.PasswordLengthLabel.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLengthLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLengthLabel.Location = new System.Drawing.Point(272, 189);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(62, 20);
            this.PasswordLengthLabel.TabIndex = 7;
            this.PasswordLengthLabel.Text = "Length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.CharacterSetLabel);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.CharacterSet);
            this.Controls.Add(this.PasswordLength);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.GenerateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Generator Plus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button GenerateButton;
        private TextBox PasswordBox;
        private TextBox PasswordLength;
        private TextBox CharacterSet;
        private Button DefaultButton;
        private Label CharacterSetLabel;
        private Label PasswordLengthLabel;
    }
}
namespace Part05
{
    partial class UserLogin
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
            this.LaelUsername = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaelUsername
            // 
            this.LaelUsername.AutoSize = true;
            this.LaelUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaelUsername.Location = new System.Drawing.Point(35, 39);
            this.LaelUsername.Name = "LaelUsername";
            this.LaelUsername.Size = new System.Drawing.Size(139, 23);
            this.LaelUsername.TabIndex = 0;
            this.LaelUsername.Text = "Enter your name :";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxUsername.Location = new System.Drawing.Point(180, 38);
            this.TextBoxUsername.MaxLength = 15;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(100, 26);
            this.TextBoxUsername.TabIndex = 1;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(39, 93);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(235, 79);
            this.ButtonStart.TabIndex = 2;
            this.ButtonStart.Text = "START !";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // UserLogin
            // 
            this.AcceptButton = this.ButtonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 205);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LaelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Button ButtonStart;
    }
}
namespace Part01
{
    partial class GamePhase01
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TextGuess = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(451, 87);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Random Game 1";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(75, 99);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(338, 90);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start !";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // TextGuess
            // 
            this.TextGuess.Location = new System.Drawing.Point(75, 195);
            this.TextGuess.Name = "TextGuess";
            this.TextGuess.Size = new System.Drawing.Size(337, 20);
            this.TextGuess.TabIndex = 2;
            this.TextGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGuess_KeyPress);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.Location = new System.Drawing.Point(75, 221);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(338, 77);
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.Text = "Submit Your Guess";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(77, 352);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(336, 77);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Exit To Desktop";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // GamePhase01
            // 
            this.AcceptButton = this.ButtonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(475, 441);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextGuess);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamePhase01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Game 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePhase01_FormClosing);
            this.Load += new System.EventHandler(this.GamePhase01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox TextGuess;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Button ButtonExit;
    }
}


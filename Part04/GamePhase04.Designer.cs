namespace Part04
{
    partial class GamePhase04
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePhase04));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TextGuess = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelCounter = new System.Windows.Forms.Label();
            this.TimerG = new System.Windows.Forms.Timer(this.components);
            this.TimerR = new System.Windows.Forms.Timer(this.components);
            this.TimerB = new System.Windows.Forms.Timer(this.components);
            this.ButtonSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(451, 87);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Random Game 4";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStart.Image")));
            this.ButtonStart.Location = new System.Drawing.Point(166, 132);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(152, 57);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // TextGuess
            // 
            this.TextGuess.Location = new System.Drawing.Point(166, 195);
            this.TextGuess.MaxLength = 2;
            this.TextGuess.Name = "TextGuess";
            this.TextGuess.Size = new System.Drawing.Size(152, 20);
            this.TextGuess.TabIndex = 2;
            this.TextGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGuess_KeyPress);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSubmit.Image")));
            this.ButtonSubmit.Location = new System.Drawing.Point(166, 221);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(152, 57);
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(77, 352);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(192, 77);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Exit To Desktop";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelCounter
            // 
            this.LabelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCounter.Location = new System.Drawing.Point(77, 281);
            this.LabelCounter.Name = "LabelCounter";
            this.LabelCounter.Size = new System.Drawing.Size(335, 68);
            this.LabelCounter.TabIndex = 6;
            this.LabelCounter.Text = "Guess";
            this.LabelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerG
            // 
            this.TimerG.Enabled = true;
            this.TimerG.Interval = 1;
            this.TimerG.Tick += new System.EventHandler(this.TimerG_Tick);
            // 
            // TimerR
            // 
            this.TimerR.Interval = 1;
            this.TimerR.Tick += new System.EventHandler(this.TimerR_Tick);
            // 
            // TimerB
            // 
            this.TimerB.Interval = 1;
            this.TimerB.Tick += new System.EventHandler(this.TimerB_Tick);
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSetting.Image")));
            this.ButtonSetting.Location = new System.Drawing.Point(12, 352);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new System.Drawing.Size(63, 76);
            this.ButtonSetting.TabIndex = 7;
            this.ButtonSetting.UseVisualStyleBackColor = true;
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // GamePhase04
            // 
            this.AcceptButton = this.ButtonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(475, 441);
            this.Controls.Add(this.ButtonSetting);
            this.Controls.Add(this.LabelCounter);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextGuess);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamePhase04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Game 4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePhase02_FormClosing);
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
        private System.Windows.Forms.Label LabelCounter;
        private System.Windows.Forms.Timer TimerG;
        private System.Windows.Forms.Timer TimerR;
        private System.Windows.Forms.Timer TimerB;
        private System.Windows.Forms.Button ButtonSetting;
    }
}


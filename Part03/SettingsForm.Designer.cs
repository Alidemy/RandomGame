namespace Part03
{
    partial class SettingsForm
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
            this.GpBoxSetting = new System.Windows.Forms.GroupBox();
            this.GpBoxHard = new System.Windows.Forms.GroupBox();
            this.RadioRandH3 = new System.Windows.Forms.RadioButton();
            this.RadioRandH2 = new System.Windows.Forms.RadioButton();
            this.RadioRandH1 = new System.Windows.Forms.RadioButton();
            this.GpBoxEasy = new System.Windows.Forms.GroupBox();
            this.RadioRandE2 = new System.Windows.Forms.RadioButton();
            this.RadioRandE1 = new System.Windows.Forms.RadioButton();
            this.RadioHard = new System.Windows.Forms.RadioButton();
            this.RadioEasy = new System.Windows.Forms.RadioButton();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GpBoxSetting.SuspendLayout();
            this.GpBoxHard.SuspendLayout();
            this.GpBoxEasy.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpBoxSetting
            // 
            this.GpBoxSetting.Controls.Add(this.GpBoxHard);
            this.GpBoxSetting.Controls.Add(this.GpBoxEasy);
            this.GpBoxSetting.Controls.Add(this.RadioHard);
            this.GpBoxSetting.Controls.Add(this.RadioEasy);
            this.GpBoxSetting.Location = new System.Drawing.Point(12, 12);
            this.GpBoxSetting.Name = "GpBoxSetting";
            this.GpBoxSetting.Size = new System.Drawing.Size(307, 168);
            this.GpBoxSetting.TabIndex = 0;
            this.GpBoxSetting.TabStop = false;
            this.GpBoxSetting.Text = "Game Settings";
            // 
            // GpBoxHard
            // 
            this.GpBoxHard.Controls.Add(this.RadioRandH3);
            this.GpBoxHard.Controls.Add(this.RadioRandH2);
            this.GpBoxHard.Controls.Add(this.RadioRandH1);
            this.GpBoxHard.Location = new System.Drawing.Point(165, 54);
            this.GpBoxHard.Name = "GpBoxHard";
            this.GpBoxHard.Size = new System.Drawing.Size(118, 100);
            this.GpBoxHard.TabIndex = 3;
            this.GpBoxHard.TabStop = false;
            // 
            // RadioRandH3
            // 
            this.RadioRandH3.AutoSize = true;
            this.RadioRandH3.Location = new System.Drawing.Point(7, 68);
            this.RadioRandH3.Name = "RadioRandH3";
            this.RadioRandH3.Size = new System.Drawing.Size(104, 17);
            this.RadioRandH3.TabIndex = 2;
            this.RadioRandH3.TabStop = true;
            this.RadioRandH3.Text = "Random to 5000";
            this.RadioRandH3.UseVisualStyleBackColor = true;
            // 
            // RadioRandH2
            // 
            this.RadioRandH2.AutoSize = true;
            this.RadioRandH2.Location = new System.Drawing.Point(7, 44);
            this.RadioRandH2.Name = "RadioRandH2";
            this.RadioRandH2.Size = new System.Drawing.Size(104, 17);
            this.RadioRandH2.TabIndex = 1;
            this.RadioRandH2.TabStop = true;
            this.RadioRandH2.Text = "Random to 1000";
            this.RadioRandH2.UseVisualStyleBackColor = true;
            // 
            // RadioRandH1
            // 
            this.RadioRandH1.AutoSize = true;
            this.RadioRandH1.Location = new System.Drawing.Point(7, 20);
            this.RadioRandH1.Name = "RadioRandH1";
            this.RadioRandH1.Size = new System.Drawing.Size(98, 17);
            this.RadioRandH1.TabIndex = 0;
            this.RadioRandH1.TabStop = true;
            this.RadioRandH1.Text = "Random to 500";
            this.RadioRandH1.UseVisualStyleBackColor = true;
            // 
            // GpBoxEasy
            // 
            this.GpBoxEasy.Controls.Add(this.RadioRandE2);
            this.GpBoxEasy.Controls.Add(this.RadioRandE1);
            this.GpBoxEasy.Location = new System.Drawing.Point(12, 54);
            this.GpBoxEasy.Name = "GpBoxEasy";
            this.GpBoxEasy.Size = new System.Drawing.Size(118, 100);
            this.GpBoxEasy.TabIndex = 2;
            this.GpBoxEasy.TabStop = false;
            // 
            // RadioRandE2
            // 
            this.RadioRandE2.AutoSize = true;
            this.RadioRandE2.Location = new System.Drawing.Point(7, 43);
            this.RadioRandE2.Name = "RadioRandE2";
            this.RadioRandE2.Size = new System.Drawing.Size(98, 17);
            this.RadioRandE2.TabIndex = 1;
            this.RadioRandE2.TabStop = true;
            this.RadioRandE2.Text = "Random to 300";
            this.RadioRandE2.UseVisualStyleBackColor = true;
            // 
            // RadioRandE1
            // 
            this.RadioRandE1.AutoSize = true;
            this.RadioRandE1.Location = new System.Drawing.Point(7, 20);
            this.RadioRandE1.Name = "RadioRandE1";
            this.RadioRandE1.Size = new System.Drawing.Size(98, 17);
            this.RadioRandE1.TabIndex = 0;
            this.RadioRandE1.TabStop = true;
            this.RadioRandE1.Text = "Random to 100";
            this.RadioRandE1.UseVisualStyleBackColor = true;
            // 
            // RadioHard
            // 
            this.RadioHard.AutoSize = true;
            this.RadioHard.Location = new System.Drawing.Point(165, 30);
            this.RadioHard.Name = "RadioHard";
            this.RadioHard.Size = new System.Drawing.Size(48, 17);
            this.RadioHard.TabIndex = 1;
            this.RadioHard.TabStop = true;
            this.RadioHard.Text = "Hard";
            this.RadioHard.UseVisualStyleBackColor = true;
            this.RadioHard.CheckedChanged += new System.EventHandler(this.RadioHard_CheckedChanged);
            // 
            // RadioEasy
            // 
            this.RadioEasy.AutoSize = true;
            this.RadioEasy.Location = new System.Drawing.Point(12, 30);
            this.RadioEasy.Name = "RadioEasy";
            this.RadioEasy.Size = new System.Drawing.Size(48, 17);
            this.RadioEasy.TabIndex = 0;
            this.RadioEasy.TabStop = true;
            this.RadioEasy.Text = "Easy";
            this.RadioEasy.UseVisualStyleBackColor = true;
            this.RadioEasy.CheckedChanged += new System.EventHandler(this.RadioEasy_CheckedChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(12, 186);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(149, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(167, 186);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(151, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(330, 220);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.GpBoxSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.GpBoxSetting.ResumeLayout(false);
            this.GpBoxSetting.PerformLayout();
            this.GpBoxHard.ResumeLayout(false);
            this.GpBoxHard.PerformLayout();
            this.GpBoxEasy.ResumeLayout(false);
            this.GpBoxEasy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpBoxSetting;
        private System.Windows.Forms.RadioButton RadioHard;
        private System.Windows.Forms.RadioButton RadioEasy;
        private System.Windows.Forms.GroupBox GpBoxHard;
        private System.Windows.Forms.GroupBox GpBoxEasy;
        private System.Windows.Forms.RadioButton RadioRandH3;
        private System.Windows.Forms.RadioButton RadioRandH2;
        private System.Windows.Forms.RadioButton RadioRandH1;
        private System.Windows.Forms.RadioButton RadioRandE2;
        private System.Windows.Forms.RadioButton RadioRandE1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
    }
}
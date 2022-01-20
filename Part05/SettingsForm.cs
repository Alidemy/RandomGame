using System;
using System.Windows.Forms;

namespace Part05
{
    public partial class SettingsForm : Form
    {
        int[] setting = { 1, 1};

        public int[] SendBack()
        {
            return setting;
        }
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RadioEasy.Checked = true;
            GpBoxEasy.Enabled = true;
            GpBoxHard.Enabled = false;
            RadioRandE1.Checked = true;
        }

        private void RadioEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioEasy.Checked)
            {
                GpBoxEasy.Enabled = true;
                GpBoxHard.Enabled = false;
            }
        }

        private void RadioHard_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioHard.Checked)
            {
                GpBoxEasy.Enabled = false;
                GpBoxHard.Enabled = true;
                RadioRandH1.Checked = true;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (RadioEasy.Checked)
            {
                setting[0] = 1;
                if (RadioRandE1.Checked)
                {
                    setting[1] = 1;
                }
                else if (RadioRandE2.Checked)
                {
                    setting[1] = 2;
                }
            }
            else if (RadioHard.Checked)
            {
                setting[0] = 2;
                if (RadioRandH1.Checked)
                {
                    setting[1] = 1;
                }
                else if (RadioRandH2.Checked)
                {
                    setting[1] = 2;
                }
                else if (RadioRandH3.Checked)
                {
                    setting[1] = 3;
                }
            }
            this.Close();
        }
    }
}

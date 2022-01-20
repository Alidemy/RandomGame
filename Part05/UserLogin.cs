using System;
using System.Windows.Forms;

namespace Part05
{
    public partial class UserLogin : Form
    {
        public string SendBack()
        {
            return TextBoxUsername.Text;
        }
        public UserLogin()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            SendBack();
            this.Close();
        }
    }
}

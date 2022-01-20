using System;
using System.Windows.Forms;

namespace Part01
{
    public partial class GamePhase01 : Form
    {
        public GamePhase01()
        {
            InitializeComponent();
        }

        int rndAnswer;
        int counter = 0;
        DialogResult mBDialog;

        private int GenRnd()
        {
            return new Random().Next(1, 100);
        }

        private void GamePhase01_Load(object sender, EventArgs e)
        {

        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            rndAnswer = GenRnd();

            MessageBox.Show("A number has been generated between 1 to 100," +
                            "\nStart guessing...", "Start !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.AcceptButton = this.ButtonSubmit;
            TextGuess.Focus();
        }

        private void TextGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (rndAnswer == 0)
            {
                MessageBox.Show("Start the game first", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextGuess.Text == "")
            {
                MessageBox.Show("Enter your guess in box above", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Convert.ToInt32(TextGuess.Text) == rndAnswer)
                {
                    MessageBox.Show($"You Guessed The Answer Correctly ! ^_^" +
                                    $"\nAfter {counter} guesses.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ButtonStart.Enabled = false;
                    TextGuess.Enabled = false;
                    ButtonSubmit.Enabled = false;
                    this.Close();
                }
                else if (Convert.ToInt32(TextGuess.Text) > rndAnswer)
                {
                    MessageBox.Show("The answer is smaller than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextGuess.Focus();
                    TextGuess.Text = "";
                    counter++;
                }
                else if (Convert.ToInt32(TextGuess.Text) < rndAnswer)
                {
                    MessageBox.Show("The answer is bigger than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextGuess.Focus();
                    TextGuess.Text = "";
                    counter++;
                }
            }

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GamePhase01_FormClosing(object sender, FormClosingEventArgs e)
        {
            mBDialog = MessageBox.Show("Do you want to leave ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mBDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

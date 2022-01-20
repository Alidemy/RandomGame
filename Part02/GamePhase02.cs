using System;
using System.Windows.Forms;

namespace Part02
{
    public partial class GamePhase02 : Form
    {
        public GamePhase02()
        {
            InitializeComponent();
        }

        int rndAnswer;
        int counter = 0;
        DialogResult mBDialog;


        private int GenRnd()
        {
            return new Random().Next(1, 99);
        }

        private void GamePhase01_Load(object sender, EventArgs e)
        {
            LabelCounter.Text = $"You can guess {10 - counter} time(s).";
        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            rndAnswer = GenRnd();

            MessageBox.Show("A number has been generated between 1 to 99," +
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
            if (rndAnswer == 0 && counter <= 9)
            {
                MessageBox.Show("Start the game first", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextGuess.Text == "" && counter <= 9)
            {
                MessageBox.Show("Enter your guess in box above", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) == rndAnswer)
                {
                    ButtonStart.Enabled = false;
                    TextGuess.Enabled = false;
                    mBDialog = MessageBox.Show($"You Guessed The Answer Correctly ! ^_^" +
                                    $"\nAfter {counter} guesses." +
                                    $"\nDo you want to play more?", "Congratulations", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mBDialog == DialogResult.Yes)
                    {
                        this.AcceptButton = ButtonStart;
                        rndAnswer = 0;
                        counter = 0;
                        LabelCounter.Text = $"You can guess {10 - counter} time(s).";
                        TextGuess.Text = "";
                        ButtonStart.Enabled = true;
                        TextGuess.Enabled = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) > rndAnswer && counter <= 9)
                {
                    MessageBox.Show("The answer is smaller than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextGuess.Focus();
                    TextGuess.Text = "";
                    counter++;
                    LabelCounter.Text = $"You can guess {10 - counter} time(s).";

                }
                else if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) < rndAnswer && counter <= 9)
                {
                    MessageBox.Show("The answer is bigger than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextGuess.Focus();
                    TextGuess.Text = "";
                    counter++;
                    LabelCounter.Text = $"You can guess {10 - counter} time(s).";

                }
                else
                {
                    ButtonStart.Enabled = false;
                    TextGuess.Enabled = false;
                    mBDialog = MessageBox.Show($"The answer was {rndAnswer}, and you couldn't guess it in 10 times." +
                        $"\nDo you want to play more?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mBDialog == DialogResult.Yes)
                    {
                        this.AcceptButton = ButtonStart;
                        rndAnswer = 0;
                        counter = 0;
                        LabelCounter.Text = $"You can guess {10 - counter} time(s).";
                        TextGuess.Text = "";
                        ButtonStart.Enabled = true;
                        TextGuess.Enabled = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GamePhase02_FormClosing(object sender, FormClosingEventArgs e)
        {
            mBDialog = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mBDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

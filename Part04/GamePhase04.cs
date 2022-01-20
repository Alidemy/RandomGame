using System;
using System.Drawing;
using System.Windows.Forms;


namespace Part04
{
    public partial class GamePhase04 : Form
    {
        public GamePhase04()
        {
            InitializeComponent();
        }

        int rndAnswer;
        int counter = 0;
        DialogResult mBDialog;
        byte gC = 192;
        byte bC = 255;
        byte rC = 192;
        int maxRand = 99;
        int maxGuess = 10;

        /// <summary>
        /// Generating a new random number due to game difficulty, And shows proper Message in MsgBox.
        /// </summary>
        /// <returns>random number in "int"</returns>
        private int GenRnd()
        {
            MessageBox.Show($"A number has been generated between 1 to {maxRand}," +
                            $"\nStart guessing...", "Start !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return new Random().Next(1, maxRand);
        }
        /// <summary>
        /// Shows a message, says that your number is bigger than the answer.
        /// </summary>
        private void MsgBigger()
        {
            TextGuess.Focus();
            TextGuess.Text = "";
            counter++;
            LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
            MessageBox.Show("The answer is bigger than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Shows a message, says that your number is smaller than the answer.
        /// </summary>
        private void MsgSmaller()
        {
            TextGuess.Focus();
            TextGuess.Text = "";
            counter++;
            LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
            MessageBox.Show("The answer is smaller than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Restarts all of the controlls on form and clear answer and counter variables.
        /// </summary>
        private void RestartGame()
        {
            this.AcceptButton = ButtonStart;
            rndAnswer = 0;
            counter = 0;
            LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
            TextGuess.Text = "";
            ButtonStart.Enabled = true;
            TextGuess.Enabled = true;
        }
        /// <summary>
        /// Giving a hint to player at cost of a guess chance.
        /// </summary>
        /// <returns>dialog result</returns>
        private DialogResult GiveHint()
        {
            mBDialog = MessageBox.Show("It'll cost you a guess chance,\nAre you ok with it?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mBDialog == DialogResult.Yes)
            {
                string restAns = (rndAnswer.ToString().Substring(0, TextGuess.MaxLength / 2));
                MessageBox.Show($"{restAns.PadRight(rndAnswer.ToString().Length, '*')}");
                counter++;
                LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                return 0;
            }
            else
            {
                return DialogResult.No;
            }
        }

        private void GamePhase01_Load(object sender, EventArgs e)
        {
            LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            rndAnswer = GenRnd();
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
            if (rndAnswer == 0 && counter <= (maxGuess - 1))
            {
                MessageBox.Show("Start the game first", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextGuess.Text == "" && counter <= (maxGuess - 1))
            {
                MessageBox.Show("Enter your guess in box above", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) == rndAnswer)
                {
                    ButtonStart.Enabled = false;
                    TextGuess.Enabled = false;
                    counter++;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                    mBDialog = MessageBox.Show($"You Guessed The Answer Correctly ! ^_^" +
                                    $"\nAfter {counter} guesses." +
                                    $"\nDo you want to play more?", "Congratulations", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mBDialog == DialogResult.Yes)
                    {
                        RestartGame();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) > rndAnswer && counter <= (maxGuess - 1))
                {
                    if (counter == (maxGuess / 2))
                    {
                        mBDialog = MessageBox.Show("Do you want a hint?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mBDialog == DialogResult.Yes)
                        {
                            mBDialog = GiveHint();
                            if (mBDialog == DialogResult.No)
                            {
                                MsgSmaller();
                            }
                        }
                        else
                        {
                            MsgSmaller();
                        }
                    }
                    else
                    {
                        MsgSmaller();
                    }
                }
                else if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) < rndAnswer && counter <= (maxGuess - 1))
                {
                    if (counter == (maxGuess / 2))
                    {
                        mBDialog = MessageBox.Show("Do you want a hint?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mBDialog == DialogResult.Yes)
                        {
                            mBDialog = GiveHint();
                            if (mBDialog == DialogResult.No)
                            {
                                MsgBigger();
                            }
                        }
                        else
                        {
                            MsgBigger();
                        }
                    }
                    else
                    {
                        MsgBigger();
                    }
                }
                else
                {
                    ButtonStart.Enabled = false;
                    TextGuess.Enabled = false;
                    mBDialog = MessageBox.Show($"The answer was {rndAnswer}, and you couldn't guess it in {maxGuess} times." +
                        $"\nDo you want to play more?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mBDialog == DialogResult.Yes)
                    {
                        RestartGame();
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

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            SettingsForm sF = new SettingsForm();
            sF.ShowDialog();
            if (sF.SendBack()[0] == 1)
            {
                if (sF.SendBack()[1] == 1)
                {
                    maxGuess = 10;
                    maxRand = 99;
                    TextGuess.MaxLength = 2;
                    RestartGame();
                }
                else if (sF.SendBack()[1] == 2)
                {
                    maxGuess = 20;
                    maxRand = 300;
                    TextGuess.MaxLength = 3;
                    RestartGame();
                }
            }
            else if (sF.SendBack()[0] == 2)
            {
                if (sF.SendBack()[1] == 1)
                {
                    maxGuess = 10;
                    maxRand = 500;
                    TextGuess.MaxLength = 3;
                    RestartGame();
                }
                else if (sF.SendBack()[1] == 2)
                {
                    maxGuess = 15;
                    maxRand = 999;
                    TextGuess.MaxLength = 3;
                    RestartGame();
                }
                else if (sF.SendBack()[1] == 3)
                {
                    maxGuess = 5;
                    maxRand = 5000;
                    TextGuess.MaxLength = 4;
                    RestartGame();
                }
            }
        }
        #region RGBbackground
        private void TimerG_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rC, gC, bC);
            if (bC == 255)
            {
                gC++;
                if (gC == 255)
                {
                    TimerG.Enabled = false;
                    TimerR.Enabled = true;
                }
            }
            else if (rC == 255)
            {
                gC--;
                if (gC == 192)
                {
                    TimerG.Enabled = false;
                    TimerR.Enabled = true;
                }
            }

        }

        private void TimerR_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rC, gC, bC);
            if (gC == 255)
            {
                bC--;
                if (bC == 192)
                {
                    TimerR.Enabled = false;
                    TimerB.Enabled = true;
                }
            }
            else if (rC == 255)
            {
                bC++;
                if (bC == 255)
                {
                    TimerR.Enabled = false;
                    TimerB.Enabled = true;

                }
            }
        }

        private void TimerB_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rC, gC, bC);
            if (bC == 192)
            {
                rC++;
                if (rC == 255)
                {
                    TimerB.Enabled = false;
                    TimerG.Enabled = true;

                }
            }
            else if (bC == 255)
            {
                rC--;
                if (rC == 192)
                {
                    TimerB.Enabled = false;
                    TimerG.Enabled = true;
                }
            }
        }

        #endregion
    }
}

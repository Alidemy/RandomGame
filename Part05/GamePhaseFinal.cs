using System;
using System.Drawing;
using System.Windows.Forms;


namespace Part05
{
    public partial class GamePhaseFinal : Form
    {
        public GamePhaseFinal()
        {
            InitializeComponent();
        }

        int rndAnswer;//the answer of game!
        int counter = 0;//counts your guesses
        DialogResult mBDialog;//holds all msgbox answers
        byte gC = 50;//counts greens for bg RGB
        byte bC = 237;//counts blues for bg RGB
        byte rC = 237;//counts reds for bg RGB
        int maxRand = 99;//maximum number of answer number, cahnges with difficulty
        int maxGuess = 10;//maximum time you can guess, cahnges with difficulty
        int win = 0;//count wins
        int lose = 0;//count loses
        int cDown = 30;//counter of game timer
        int tForLabel;//uses to save amount of time
        int tInterval = 25;//uses to sync background color with time you have
        byte freezeT = 0;//uses in unfreeze to find last active timer

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
            rndAnswer = 0;
            counter = 0;
            gC = 50;
            bC = 237;
            rC = 237;
            cDown = tForLabel;
            this.BackColor = Color.FromArgb(rC, gC, bC);
            TimerB.Interval = tInterval;
            TimerG.Interval = tInterval;
            TimerR.Interval = tInterval;
            LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
            TextGuess.Text = "";
            ButtonStart.Enabled = true;
            TextGuess.Enabled = true;
            this.AcceptButton = ButtonStart;
            LabelWin.Text = $"Win : {win}";
            LabelLose.Text = $"Lose : {lose}";
            LabelTimer.Text = tForLabel.ToString();
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
        /// <summary>
        /// Stops the game when time runs out...
        /// </summary>
        private void TimesUp()
        {
            ButtonStart.Enabled = false;
            TextGuess.Enabled = false;
            TimerCDown.Enabled = false;
            lose++;
            mBDialog = MessageBox.Show($"The answer was {rndAnswer}, and you couldn't guess it in {tForLabel} seconds." +
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
        /// <summary>
        /// Stops all timers and start button
        /// </summary>
        private void Freeze()
        {
            ButtonStart.Enabled = false;
            TextGuess.Enabled = false;
            TimerG.Enabled = false;
            TimerB.Enabled = false;
            TimerR.Enabled = false;
            TimerCDown.Enabled = false;
        }
        /// <summary>
        /// Apposite of Freeze method
        /// </summary>
        private void UnFreeze()
        {
            ButtonStart.Enabled = true;
            TextGuess.Enabled = true;
            if (freezeT == 0)
            {
                TimerB.Enabled = true;
            }
            else if (freezeT == 1)
            {
                TimerG.Enabled = true;
            }
            else if (freezeT == 2)
            {
                TimerR.Enabled = true;
            }
            TimerCDown.Enabled = true;
        }

        private void GamePhase01_Load(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
            tForLabel = cDown;
            LabelUsername.Text = ul.SendBack();
            LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
            LabelWin.Text = $"Win : {win}";
            LabelLose.Text = $"Lose : {lose}";
            LabelTimer.Text = cDown.ToString();
            TimerB.Interval = tInterval;
            TimerG.Interval = tInterval;
            TimerR.Interval = tInterval;
            //how are you ?
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            rndAnswer = GenRnd();
            this.AcceptButton = this.ButtonSubmit;
            TextGuess.Focus();
            TimerCDown.Enabled = true;
            TimerB.Enabled = true;
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
                    counter++;
                    win++;
                    Freeze();
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
                        Freeze();
                        mBDialog = MessageBox.Show("Do you want a hint?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mBDialog == DialogResult.Yes)
                        {
                            mBDialog = GiveHint();
                            if (mBDialog == DialogResult.No)
                            {
                                UnFreeze();
                                MsgSmaller();
                            }
                        }
                        else
                        {
                            UnFreeze();
                            MsgSmaller();
                        }
                    }
                    else
                    {
                        UnFreeze();
                        MsgSmaller();
                    }
                }
                else if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) < rndAnswer && counter <= (maxGuess - 1))
                {
                    if (counter == (maxGuess / 2))
                    {
                        Freeze();
                        mBDialog = MessageBox.Show("Do you want a hint?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mBDialog == DialogResult.Yes)
                        {
                            mBDialog = GiveHint();
                            if (mBDialog == DialogResult.No)
                            {
                                UnFreeze();
                                MsgBigger();
                            }
                        }
                        else
                        {
                            UnFreeze();
                            MsgBigger();
                        }
                    }
                    else
                    {
                        UnFreeze();
                        MsgBigger();
                    }
                }
                else
                {
                    Freeze();
                    lose++;
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
            Freeze();
            mBDialog = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mBDialog == DialogResult.No)
            {
                UnFreeze();
                e.Cancel = true;
            }
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            Freeze();
            SettingsForm sF = new SettingsForm();
            sF.ShowDialog();
            if (sF.SendBack()[0] == 1)
            {
                if (sF.SendBack()[1] == 1)
                {
                    maxGuess = 10;
                    maxRand = 99;
                    tForLabel = 30;
                    TextGuess.MaxLength = 2;
                    tInterval = 25;
                    RestartGame();
                }
                else if (sF.SendBack()[1] == 2)
                {
                    maxGuess = 20;
                    maxRand = 300;
                    tForLabel = 40;
                    TextGuess.MaxLength = 3;
                    tInterval = 30;
                    RestartGame();
                }
            }
            else if (sF.SendBack()[0] == 2)
            {
                if (sF.SendBack()[1] == 1)
                {
                    maxGuess = 10;
                    maxRand = 500;
                    tForLabel = 50;
                    TextGuess.MaxLength = 3;
                    tInterval = 48;
                    RestartGame();
                }
                else if (sF.SendBack()[1] == 2)
                {
                    maxGuess = 15;
                    maxRand = 999;
                    tForLabel = 60;
                    TextGuess.MaxLength = 3;
                    tInterval = 50;
                    RestartGame();
                }
                else if (sF.SendBack()[1] == 3)
                {
                    maxGuess = 5;
                    maxRand = 5000;
                    tForLabel = 60;
                    TextGuess.MaxLength = 4;
                    tInterval = 50;
                    RestartGame();
                }
            }
        }

        #region RGBbackground

        private void TimerG_Tick(object sender, EventArgs e)
        {
            freezeT = 1;
            this.BackColor = Color.FromArgb(rC, gC, bC);
            if (bC == 237)
            {
                gC++;
                if (gC == 237)
                {
                    TimerG.Enabled = false;
                    TimerR.Enabled = true;
                }
            }
            else if (rC == 237)
            {
                gC--;
                if (gC == 50)
                {
                    TimerG.Enabled = false;
                    TimerR.Enabled = false;
                }
            }

        }

        private void TimerR_Tick(object sender, EventArgs e)
        {
            freezeT = 2;
            this.BackColor = Color.FromArgb(rC, gC, bC);
            if (gC == 237)
            {
                bC--;
                if (bC == 50)
                {
                    TimerR.Enabled = false;
                    TimerB.Enabled = true;
                }
            }
            else if (rC == 237)
            {
                bC++;
                if (bC == 237)
                {
                    TimerR.Enabled = false;
                    TimerB.Enabled = true;

                }
            }
        }

        private void TimerB_Tick(object sender, EventArgs e)
        {
            freezeT = 0;
            this.BackColor = Color.FromArgb(rC, gC, bC);
            if (bC == 50)
            {
                rC++;
                if (rC == 237)
                {
                    TimerB.Enabled = false;
                    TimerG.Enabled = true;

                }
            }
            else if (bC == 237)
            {
                rC--;
                if (rC == 50)
                {
                    TimerB.Enabled = false;
                    TimerG.Enabled = true;
                }
            }
        }

        #endregion

        private void TimerCDown_Tick(object sender, EventArgs e)
        {
            cDown--;
            LabelTimer.Text = cDown.ToString();
            if (cDown == 0)
            {
                TimesUp();
            }
        }

    }
}

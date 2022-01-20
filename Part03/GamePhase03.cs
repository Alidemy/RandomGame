using System;
using System.Drawing;
using System.Windows.Forms;


namespace Part03
{
    public partial class GamePhase03 : Form
    {
        public GamePhase03()
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


        private int GenRnd()
        {
            return new Random().Next(1, maxRand);
        }

        private void GamePhase01_Load(object sender, EventArgs e)
        {
            LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";

        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            rndAnswer = GenRnd();

            MessageBox.Show($"A number has been generated between 1 to {maxRand}," +
                            $"\nStart guessing...", "Start !", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        this.AcceptButton = ButtonStart;
                        rndAnswer = 0;
                        counter = 0;
                        LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                        TextGuess.Text = "";
                        ButtonStart.Enabled = true;
                        TextGuess.Enabled = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) > rndAnswer && counter <= (maxGuess - 1))
                {
                    MessageBox.Show("The answer is smaller than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextGuess.Focus();
                    TextGuess.Text = "";
                    counter++;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";

                }
                else if (TextGuess.Text != "" && Convert.ToInt32(TextGuess.Text) < rndAnswer && counter <= (maxGuess - 1))
                {
                    MessageBox.Show("The answer is bigger than your number, keep guessing", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextGuess.Focus();
                    TextGuess.Text = "";
                    counter++;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";

                }
                else
                {
                    ButtonStart.Enabled = false;
                    TextGuess.Enabled = false;
                    mBDialog = MessageBox.Show($"The answer was {rndAnswer}, and you couldn't guess it in {maxGuess} times." +
                        $"\nDo you want to play more?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mBDialog == DialogResult.Yes)
                    {
                        this.AcceptButton = ButtonStart;
                        rndAnswer = 0;
                        counter = 0;
                        LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
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

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            SettingsForm sF = new SettingsForm();
            sF.ShowDialog();
            if (sF.SendBack()[0] == 1)
            {
                if (sF.SendBack()[1] == 1)
                {
                    this.AcceptButton = ButtonStart;
                    rndAnswer = 0;
                    counter = 0;
                    maxGuess = 10;
                    maxRand = 99;
                    TextGuess.MaxLength = 2;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                    TextGuess.Text = "";
                    ButtonStart.Enabled = true;
                    TextGuess.Enabled = true;
                }
                else if (sF.SendBack()[1] == 2)
                {
                    this.AcceptButton = ButtonStart;
                    rndAnswer = 0;
                    counter = 0;
                    maxGuess = 20;
                    maxRand = 300;
                    TextGuess.MaxLength = 3;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                    TextGuess.Text = "";
                    ButtonStart.Enabled = true;
                    TextGuess.Enabled = true;
                }
            }
            else if (sF.SendBack()[0] == 2)
            {
                if (sF.SendBack()[1] == 1)
                {
                    this.AcceptButton = ButtonStart;
                    rndAnswer = 0;
                    counter = 0;
                    maxGuess = 10;
                    maxRand = 500;
                    TextGuess.MaxLength = 3;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                    TextGuess.Text = "";
                    ButtonStart.Enabled = true;
                    TextGuess.Enabled = true;
                }
                else if (sF.SendBack()[1] == 2)
                {
                    this.AcceptButton = ButtonStart;
                    rndAnswer = 0;
                    counter = 0;
                    maxGuess = 15;
                    maxRand = 999;
                    TextGuess.MaxLength = 3;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                    TextGuess.Text = "";
                    ButtonStart.Enabled = true;
                    TextGuess.Enabled = true;
                }
                else if (sF.SendBack()[1] == 3)
                {
                    this.AcceptButton = ButtonStart;
                    rndAnswer = 0;
                    counter = 0;
                    maxGuess = 5;
                    maxRand = 5000;
                    TextGuess.MaxLength = 4;
                    LabelCounter.Text = $"You can guess {maxGuess - counter} time(s).";
                    TextGuess.Text = "";
                    ButtonStart.Enabled = true;
                    TextGuess.Enabled = true;
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

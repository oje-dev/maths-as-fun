using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsAsFun___Arithmetic_Practise_App
{
    public partial class FrmMainApplication : Form
    {
        //These class member variables are used many methods within this class.
        private static int totalQuestionsAnswered = 0;
        private static int totalQuestionsCorrect = 0;
        private static int timeRemaining;

        public FrmMainApplication()
        {
            InitializeComponent();
        }

        private void FrmMainApplication_Load(object sender, EventArgs e)
        {

        }

        private void FrmMainApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnTimesTable_Click(object sender, EventArgs e)
        {
            FrmMultiplicationTable frmMultiplicationTable = new FrmMultiplicationTable();
            frmMultiplicationTable.ShowDialog();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            lblFirstNumber.Visible = true;
            lblOperator.Visible = true;
            lblSecondNumber.Visible = true;
            lblEquals.Visible = true;
            txtAnswer.Visible = true;
            lblScore.Visible = false;
            totalQuestionsAnswered = 0;
            totalQuestionsCorrect = 0;
            lblScore.Font = new Font(lblScore.Font.FontFamily, 20);
            txtAnswer.Text = null;
            lblIncorrect.Visible = false;
            imgGreenTick.Visible = false;
            if (rdbTimedMode.Checked == true)
            {
                RestartTimer();
                lblTimerText.Visible = true;
                lblTimer.Visible = true;
                timeRemaining = GetTimeAllowed();
                lblTimer.Text = Convert.ToString(timeRemaining / 1000);
                TimeWarningColourChange();
                lblTimer.Location = new Point((pnlTimer.Width - lblTimer.Width) / 2, ((pnlTimer.Height - lblTimer.Height)) / 2);
                tmrTimedMode.Enabled = true;
            }
            else
            {
                tmrTimedMode.Enabled = false;
                lblTimer.Visible = false;
                lblTimerText.Visible = false;
            }
            DisplaySum();
        }

        private void DisplaySum()
        {
            Functions functions = new Functions();
            int[] twoNumberArray;
            if (rdbPositive.Checked == true)
            {
                if (rdbAddition.Checked == true)
                {
                    lblOperator.Text = "+";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Addition, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Addition, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Addition, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Positive);
                    }
                }
                else if (rdbSubtraction.Checked == true)
                {
                    lblOperator.Text = "-";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Subtraction, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Subtraction, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Subtraction, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Positive);
                    }
                }
                else if (rdbMultiplication.Checked == true)
                {
                    lblOperator.Text = "×";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Multiplication, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Multiplication, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Multiplication, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Positive);
                    }
                }
                else
                {
                    lblOperator.Text = "÷";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Division, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Division, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Division, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Positive);
                    }
                }
            }
            else
            {
                if (rdbAddition.Checked == true)
                {
                    lblOperator.Text = "+";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Addition, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Addition, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Addition, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Negative);
                    }
                }
                else if (rdbSubtraction.Checked == true)
                {
                    lblOperator.Text = "-";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Subtraction, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Subtraction, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Subtraction, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Negative);
                    }
                }
                else if (rdbMultiplication.Checked == true)
                {
                    lblOperator.Text = "×";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Multiplication, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Multiplication, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Multiplication, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Negative);
                    }
                }
                else
                {
                    lblOperator.Text = "÷";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Division, Functions.Magnitude.Ten, Functions.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Division, Functions.Magnitude.Hundred, Functions.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = functions.GetTwoNumbers(Functions.Operation.Division, Functions.Magnitude.Thousand, Functions.PostiveOrNegative.Negative);
                    }
                }
            }
            lblFirstNumber.Text = Convert.ToString(twoNumberArray[0]);
            lblSecondNumber.Text = Convert.ToString(twoNumberArray[1]);
            lblFirstNumber.Location = new Point((pnlFirstNumber.Width - lblFirstNumber.Width) / 2, ((pnlFirstNumber.Height - lblFirstNumber.Height)) / 2);
            lblSecondNumber.Location = new Point((pnlSecondNumber.Width - lblSecondNumber.Width) / 2, ((pnlSecondNumber.Height - lblSecondNumber.Height)) / 2);
        }

        private int GetAnswer()
        {
            int answer;
            if (lblOperator.Text == "+")
            {
                answer = (Convert.ToInt32(lblFirstNumber.Text) + Convert.ToInt32(lblSecondNumber.Text));
            }
            else if (lblOperator.Text == "-")
            {
                answer = (Convert.ToInt32(lblFirstNumber.Text) - Convert.ToInt32(lblSecondNumber.Text));
            }
            else if (lblOperator.Text == "×")
            {
                answer = (Convert.ToInt32(lblFirstNumber.Text) * Convert.ToInt32(lblSecondNumber.Text));
            }
            else
            {
                answer = (Convert.ToInt32(lblFirstNumber.Text) / Convert.ToInt32(lblSecondNumber.Text));
            }
            return answer;
        }

        private void CheckAnswer(int answer)
        {
            totalQuestionsAnswered += 1;
            if (txtAnswer.Text == Convert.ToString(answer))
            {
                totalQuestionsCorrect += 1;
                lblIncorrect.Visible = false;
                imgGreenTick.Visible = true;
            }
            else
            {
                imgGreenTick.Visible = false;
                lblIncorrect.Visible = true;
                lblIncorrect.Text = Convert.ToString(answer) + "!";
            }
            txtAnswer.Text = null;
        }

        private void TxtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (totalQuestionsAnswered < 1000)
                {
                    AcceptAnswer();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    tmrTimedMode.Enabled = false;
                    lblTimerText.Visible = false;
                    lblTimer.Visible = false;
                    lblScore.Font = new Font(lblScore.Font.FontFamily, 9);
                    lblScore.Text = "The maximum number of questions have been answered.\nPlease press the practise button to start a new session.";
                }
            }
        }

        private double GetPercentage()
        {
            double percentageCorrect = (Convert.ToDouble(totalQuestionsCorrect) / Convert.ToDouble(totalQuestionsAnswered)) * 100.0;
            percentageCorrect = Math.Round(percentageCorrect, 2);
            return percentageCorrect;
        }

        private void SetScore(double percentageCorrect)
        {
            lblScore.Text = Convert.ToString(totalQuestionsCorrect) + "/" + Convert.ToString(totalQuestionsAnswered) + " " + Convert.ToString(percentageCorrect) + "%";
            if (percentageCorrect >= 80.0)
            {
                lblScore.Text += " Keep it up!";
                lblScore.ForeColor = Color.Green;
            }
            else if (percentageCorrect >= 60)
            {
                lblScore.Text += " Keep Going!";
                lblScore.ForeColor = ColorTranslator.FromHtml("#FAB005");
            }
            else
            {
                lblScore.Text += " Try Harder!";
                lblScore.ForeColor = Color.Red;
            }
        }

        private int GetTimeAllowed()
        {
            int getTimeRemaining;
            if (rdbAddition.Checked == true)
            {
                if (rdbTen.Checked == true)
                {
                    getTimeRemaining = 4;
                }
                else if (rdbHundred.Checked == true)
                {
                    getTimeRemaining = 12;
                }
                else
                {
                    getTimeRemaining = 30;
                }
            }
            else if (rdbSubtraction.Checked == true)
            {
                if (rdbTen.Checked == true)
                {
                    getTimeRemaining = 4;
                }
                else if (rdbHundred.Checked == true)
                {
                    getTimeRemaining = 12;
                }
                else
                {
                    getTimeRemaining = 30;
                }
            }
            else if (rdbMultiplication.Checked == true)
            {
                if (rdbTen.Checked == true)
                {
                    getTimeRemaining = 8;
                }
                else if (rdbHundred.Checked == true)
                {
                    getTimeRemaining = 90;
                }
                else
                {
                    getTimeRemaining = 210;
                }
            }
            else
            {
                if (rdbTen.Checked == true)
                {
                    getTimeRemaining = 4;
                }
                else if (rdbHundred.Checked == true)
                {
                    getTimeRemaining = 12;
                }
                else
                {
                    getTimeRemaining = 45;
                }
            }
            return getTimeRemaining *= 1000;
        }

        private void TmrTimedMode_Tick(object sender, EventArgs e)
        {
            timeRemaining -= 1000;
            lblTimer.Text = Convert.ToString(timeRemaining / 1000);
            TimeWarningColourChange();
            lblTimer.Location = new Point((pnlTimer.Width - lblTimer.Width) / 2, ((pnlTimer.Height - lblTimer.Height)) / 2);
            if (timeRemaining == 0)
            {
                RestartTimer();
                AcceptAnswer();
            }
        }

        private void FrmMainApplication_Activated(object sender, EventArgs e)
        {
            tmrTimedMode.Enabled = true;
        }

        private void FrmMainApplication_Deactivate(object sender, EventArgs e)
        {
            tmrTimedMode.Enabled = false;
        }

        private void RestartTimer()
        {
            tmrTimedMode.Enabled = false;
            timeRemaining = GetTimeAllowed();
            tmrTimedMode.Enabled = true;
        }

        private void AcceptAnswer()
        {
            if (totalQuestionsAnswered < 1000)
            {
                if (lblScore.Visible == false)
                {
                    lblScore.Visible = true;
                }
                if (rdbTimedMode.Checked == true)
                {
                    RestartTimer();
                    lblTimerText.Visible = true;
                    lblTimer.Visible = true;
                    timeRemaining = GetTimeAllowed();
                    lblTimer.Text = Convert.ToString(timeRemaining / 1000);
                    TimeWarningColourChange();
                    lblTimer.Location = new Point((pnlTimer.Width - lblTimer.Width) / 2, ((pnlTimer.Height - lblTimer.Height)) / 2);
                    tmrTimedMode.Enabled = true;
                }
                else
                {
                    tmrTimedMode.Enabled = false;
                    lblTimer.Visible = false;
                    lblTimerText.Visible = false;
                }
                CheckAnswer(GetAnswer());
                SetScore(GetPercentage());
                DisplaySum();
            }
            else
            {
                tmrTimedMode.Enabled = false;
                lblTimerText.Visible = false;
                lblTimer.Visible = false;
                lblScore.Font = new Font(lblScore.Font.FontFamily, 9);
                lblScore.Text = "The maximum number of questions have been answered.\nPlease press the practise button to start a new session.";
            }
        }

        private void TimeWarningColourChange()
        {
            if (timeRemaining <= 3000)
            {
                lblTimer.ForeColor = Color.Red;
            }
            else
            {
                lblTimer.ForeColor = SystemColors.ControlText;
            }
        }
    }
}

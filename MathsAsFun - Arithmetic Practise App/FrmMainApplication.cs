using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsAsFun___Arithmetic_Practise_App
{
    public partial class FrmMainApplication : Form
    {
        //These class member variables are used by many methods within this class.
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
            Application.Exit(); //Since the loading screen is the starting form of the application, this line is required to ensure the application exits when the main form is closed.
        }

        private void BtnTimesTable_Click(object sender, EventArgs e)
        {
            FrmMultiplicationTable frmMultiplicationTable = new FrmMultiplicationTable();
            frmMultiplicationTable.ShowDialog();
        }

        private void BtnStart_Click(object sender, EventArgs e) //Starts a new session of questions.
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
                lblTimer.Location = new Point((pnlTimer.Width - lblTimer.Width) / 2, ((pnlTimer.Height - lblTimer.Height)) / 2); //Centres the timer label within its parent panel.
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

        private void DisplaySum() //This method retrieves the two number array from the methods class. The settings selected by the user dictate the numbers generated. They are then shown on the form.
        {
            Methods methods = new Methods();
            int[] twoNumberArray;
            //The following statements call the GetTwoNumbers method in the Methods class. The parameters passed in are decided by the combinations of radio buttons selected by the user on the form.
            if (rdbPositive.Checked == true)
            {
                if (rdbAddition.Checked == true)
                {
                    lblOperator.Text = "+";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Addition, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Addition, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Addition, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Positive);
                    }
                }
                else if (rdbSubtraction.Checked == true)
                {
                    lblOperator.Text = "-";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Subtraction, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Subtraction, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Subtraction, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Positive);
                    }
                }
                else if (rdbMultiplication.Checked == true)
                {
                    lblOperator.Text = "×";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Multiplication, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Multiplication, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Multiplication, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Positive);
                    }
                }
                else
                {
                    lblOperator.Text = "÷";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Division, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Positive);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Division, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Positive);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Division, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Positive);
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
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Addition, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Addition, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Addition, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Negative);
                    }
                }
                else if (rdbSubtraction.Checked == true)
                {
                    lblOperator.Text = "-";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Subtraction, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Subtraction, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Subtraction, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Negative);
                    }
                }
                else if (rdbMultiplication.Checked == true)
                {
                    lblOperator.Text = "×";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Multiplication, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Multiplication, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Multiplication, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Negative);
                    }
                }
                else
                {
                    lblOperator.Text = "÷";
                    if (rdbTen.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Division, Methods.Magnitude.Ten, Methods.PostiveOrNegative.Negative);
                    }
                    else if (rdbHundred.Checked == true)
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Division, Methods.Magnitude.Hundred, Methods.PostiveOrNegative.Negative);
                    }
                    else
                    {
                        twoNumberArray = methods.GetTwoNumbers(Methods.Operation.Division, Methods.Magnitude.Thousand, Methods.PostiveOrNegative.Negative);
                    }
                }
            }
            lblFirstNumber.Text = Convert.ToString(twoNumberArray[0]);
            lblSecondNumber.Text = Convert.ToString(twoNumberArray[1]);
            lblFirstNumber.Location = new Point((pnlFirstNumber.Width - lblFirstNumber.Width) / 2, ((pnlFirstNumber.Height - lblFirstNumber.Height)) / 2); //This line centres the first number within its parent panel.
            lblSecondNumber.Location = new Point((pnlSecondNumber.Width - lblSecondNumber.Width) / 2, ((pnlSecondNumber.Height - lblSecondNumber.Height)) / 2); //This line does the same with the second number.
        }

        private int GetAnswer() //This method returns the correct answer based on the two numbers shown and the operation selected.
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

        private void CheckAnswer(int answer) //This method checks that the answer given by the user is correct or incorrect.
        {
            totalQuestionsAnswered += 1; //Every question answered adds one to the total.
            if (txtAnswer.Text == Convert.ToString(answer))
            {
                totalQuestionsCorrect += 1; //Only correct answers increase this variable.
                lblIncorrect.Visible = false;
                imgGreenTick.Visible = true;
            }
            else
            {
                imgGreenTick.Visible = false;
                lblIncorrect.Visible = true;
                lblIncorrect.Text = Convert.ToString(answer) + "!"; //The correct answer is displayed if the user enters the incorrect answer.
            }
            txtAnswer.Text = null;
        }

        private void TxtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //This allows the user to press the enter key to submit their answer.
            {
                if (totalQuestionsAnswered < 1000) //To avoid the user holding down the enter key and rapidly answering many questions, a limit is set to 1000 questions per session.
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
                    lblScore.Text = "The maximum number of questions have been answered.\nPlease press the practise button to start a new session."; //A message is shown telling the user that 1000 questions have been answered.
                }
            }
        }

        private double GetPercentage() //This method returns the current percentage of correct answers to toal questions answered.
        {
            double percentageCorrect = (Convert.ToDouble(totalQuestionsCorrect) / Convert.ToDouble(totalQuestionsAnswered)) * 100.0;
            percentageCorrect = Math.Round(percentageCorrect, 2); //The percentage is rounded to two decimal places.
            return percentageCorrect;
        }

        private void SetScore(double percentageCorrect) //This method takes the current percentage and updates the label on the form according to how well the user is doing.
        {
            lblScore.Text = Convert.ToString(totalQuestionsCorrect) + "/" + Convert.ToString(totalQuestionsAnswered) + " " + Convert.ToString(percentageCorrect) + "%";
            if (percentageCorrect >= 80.0) //80% and above correctly answered questions shows a green well done message.
            {
                lblScore.Text += " Keep it up!";
                lblScore.ForeColor = Color.Green;
            }
            else if (percentageCorrect >= 60) //60% or over but below 80% shows a yellow message and an encouraging message.
            {
                lblScore.Text += " Keep Going!";
                lblScore.ForeColor = Color.FromArgb(250, 176, 5);
            }
            else //Less than 60% shows a red, try harder message.
            {
                lblScore.Text += " Try Harder!";
                lblScore.ForeColor = Color.Red;
            }
        }

        private int GetTimeAllowed() //This method returns the time remaining based on the difficulty of questions selected by the user.
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
            return getTimeRemaining *= 1000; //The total time allowed for each question is multiplied by 1000 to convert it to milliseconds.
        }

        private void TmrTimedMode_Tick(object sender, EventArgs e)
        {
            timeRemaining -= 1000; //The timer ticks every second and so reduces the time remaining by 1000 milliseconds.
            lblTimer.Text = Convert.ToString(timeRemaining / 1000);
            TimeWarningColourChange();
            lblTimer.Location = new Point((pnlTimer.Width - lblTimer.Width) / 2, ((pnlTimer.Height - lblTimer.Height)) / 2); //This line centres the timer label within its parent panel.
            if (timeRemaining == 0)
            {
                RestartTimer();
                AcceptAnswer();
            }
        }

        private void FrmMainApplication_Activated(object sender, EventArgs e)
        {
            tmrTimedMode.Enabled = true; //This stops the timer ticking if the multiplication grid is opened or the form is minimised.
        }

        private void FrmMainApplication_Deactivate(object sender, EventArgs e)
        {
            tmrTimedMode.Enabled = false; //This line restarts the timer when the form is active again.
        }

        private void RestartTimer() //This method restarts the timer. It is called when the timer hits 0 or when the user submits an answer.
        {
            tmrTimedMode.Enabled = false;
            timeRemaining = GetTimeAllowed();
            tmrTimedMode.Enabled = true;
        }

        private void AcceptAnswer() //This method is called when the user presses enter to submit their answer or when the timer runs down to 0.
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
                    lblTimer.Location = new Point((pnlTimer.Width - lblTimer.Width) / 2, ((pnlTimer.Height - lblTimer.Height)) / 2); //Centres the timer text within its parent panel.
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
                lblScore.Text = "The maximum number of questions have been answered.\nPlease press the practise button to start a new session."; //This message is shown if the total number of answers this session exceeds 1000.
            }
        }

        private void TimeWarningColourChange() //This method changes the colour of the timer to red when there are 3 seconds or fewer remaining, and changes it back to black otherwise.
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

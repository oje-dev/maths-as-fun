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
        readonly Functions functions = new Functions();

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
            DisplaySum();
        }

        private void DisplaySum()
        {
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
            if (txtAnswer.Text == Convert.ToString(answer))
            {
                lblFeedback.Text = "Correct!";
                lblFeedback.ForeColor = Color.Green;
            }
            else
            {
                lblFeedback.Text = Convert.ToString(answer);
                lblFeedback.ForeColor = Color.Red;
            }
            lblFeedback.Visible = true;
            txtAnswer.Text = null;
        }

        private void TxtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer(GetAnswer());
                e.Handled = true;
                e.SuppressKeyPress = true;
                DisplaySum();
            }
        }
    }
}

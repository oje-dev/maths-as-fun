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
            GetSum();
        }

        public void GetSum()
        {
            int[] twoNumberArray = null;
            if (rdbPositive.Checked == true)
            {
                if (rdbAddition.Checked == true)
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
                else if (rdbSubtraction.Checked == true)
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
                else if (rdbMultiplication.Checked == true)
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
            }
            else
            {
                if (rdbAddition.Checked == true)
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
                else if (rdbSubtraction.Checked == true)
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
                else if (rdbMultiplication.Checked == true)
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    if (rdbTen.Checked == true)
                    {
                    }
                    else if (rdbHundred.Checked == true)
                    {

                    }
                    else
                    {

                    }
                }
            }
            lblFirstNumber.Text = Convert.ToString(twoNumberArray[0]);
            lblSecondNumber.Text = Convert.ToString(twoNumberArray[1]);
        }
    }
}

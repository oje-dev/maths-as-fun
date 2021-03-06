﻿using System;
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
    public partial class FrmMultiplicationTable : Form
    {
        public FrmMultiplicationTable()
        {
            InitializeComponent();
        }

        private void FrmMultiplicationTable_Load(object sender, EventArgs e)
        {
            cboTimesTable.SelectedIndex = 3;
            grdTimesTable.Columns[0].DefaultCellStyle.BackColor = Color.Yellow; //This sets the first column to be highlighted yellow.
            grdTimesTable.Rows[0].DefaultCellStyle.BackColor = Color.Yellow; //This does the same with the first row.
            grdTimesTable.Rows[0].Cells[0].Value = "x"; //This sets the value of the top left cell to a multiplication sign.
            CreateTable();
        }

        private void CreateTable() //This method creates the multiplication table based on the array created in the methods class.
        {
            Methods methods = new Methods();
            int selectedTimesTable = Convert.ToInt16(char.ToString(cboTimesTable.Text.ToCharArray()[0]) + char.ToString(cboTimesTable.Text.ToCharArray()[1])); //Converts the text in the combo box to an integer which is used to generate the numbers for the grid.
            grdTimesTable.ColumnCount = selectedTimesTable + 1; //The column count is set to be one more than the selected times table, this accounts for the yellow header row and column.
            grdTimesTable.RowCount = grdTimesTable.ColumnCount; //The number of rows is set to be the same as the number of columns.
            int totalRowHeight = 0, totalColumnWidth = 0;
            foreach (DataGridViewRow rows in grdTimesTable.Rows)
            {
                totalRowHeight += rows.Height; //Gets the total row height.
            }
            foreach (DataGridViewColumn columns in grdTimesTable.Columns)
            {
                totalColumnWidth += columns.Width; //Gets the total column width.
            }
            grdTimesTable.Width = totalColumnWidth + 25; //These lines change the total height and width of the parent container
            grdTimesTable.Height = totalRowHeight + 10; //based on the number of rows and columns so that it can be centred in the form.
            grdTimesTable.Left = (ClientSize.Width - grdTimesTable.Width) / 2;
            grdTimesTable.Top = ((ClientSize.Height - grdTimesTable.Height) / 2) + 12;
            int[,] timesTableArray = methods.TimesTableArrayMethod(selectedTimesTable); //Gets the array from the methods class.
            //The following loops fill in the grid with the numbers from the array.
            for (int i = 0; i < selectedTimesTable; i++)
            {
                for (int j = 0; j < selectedTimesTable; j++)
                {
                    if (i == 0)
                    {
                        grdTimesTable.Rows[i].Cells[j + 1].Value = timesTableArray[i, j]; //This line sets the values for the first column, skipping the top left cell.
                    }
                    if (j == 0)
                    {
                        grdTimesTable.Rows[i + 1].Cells[j].Value = timesTableArray[i, j]; //This does the same for the first row.
                    }
                    else if (i == j)
                    {
                        grdTimesTable.Rows[i].Cells[j].Style.BackColor = Color.Red; //This line ensures that the first square number cell is highlighted red.
                        grdTimesTable.Rows[i].Cells[j].Style.ForeColor = Color.White; //This line ensures that the text in the first square number cell is white.
                        if (i == selectedTimesTable - 1)
                        {
                            grdTimesTable.Rows[i + 1].Cells[j + 1].Style.BackColor = Color.Red; //This line ensures that the square number cells are highlighted red.
                            grdTimesTable.Rows[i + 1].Cells[j + 1].Style.ForeColor = Color.White; //This line ensures that the text in the square number cells are white.
                        }
                    }
                    grdTimesTable.Rows[i + 1].Cells[j + 1].Value = timesTableArray[i, j]; //This line cets the value of each cell to the corresponding array element.
                }
            }
        }

        private void CboTimesTable_SelectedIndexChanged(object sender, EventArgs e) //This ensures that the grid is updated every time a new times table is selected by the user.
        {
            CreateTable();
        }
    }
}

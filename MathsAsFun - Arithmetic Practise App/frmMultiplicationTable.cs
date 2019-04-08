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
    public partial class FrmMultiplicationTable : Form
    {
        Functions functions = new Functions();

        public FrmMultiplicationTable()
        {
            InitializeComponent();
        }

        private void FrmMultiplicationTable_Load(object sender, EventArgs e)
        {
            cboTimesTable.SelectedIndex = 3;
            grdTimesTable.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;
            grdTimesTable.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
            grdTimesTable.Rows[0].Cells[0].Value = "x";
            CreateTable();
        }

        private void CreateTable()
        {
            int selectedTimesTable = 2;
            switch (cboTimesTable.Text)
            {
                case "3 Times Table": selectedTimesTable = 3; break;
                case "4 Times Table": selectedTimesTable = 4; break;
                case "5 Times Table": selectedTimesTable = 5; break;
                case "6 Times Table": selectedTimesTable = 6; break;
                case "7 Times Table": selectedTimesTable = 7; break;
                case "8 Times Table": selectedTimesTable = 8; break;
                case "9 Times Table": selectedTimesTable = 9; break;
                case "10 Times Table": selectedTimesTable = 10; break;
                case "11 Times Table": selectedTimesTable = 11; break;
                case "12 Times Table": selectedTimesTable = 12; break;
                default: break;
            }
            grdTimesTable.ColumnCount = selectedTimesTable + 1;
            grdTimesTable.RowCount = grdTimesTable.ColumnCount;
            for (int i = 0; i < selectedTimesTable; i++)
            {
                for (int j = 0; j < selectedTimesTable; j++)
                {
                    if (i == 0)
                    {
                        grdTimesTable.Rows[i].Cells[j + 1].Value = functions.TimesTableArrayFunction(selectedTimesTable)[i, j];
                    }
                    else if (j == 0)
                    {
                        grdTimesTable.Rows[i + 1].Cells[j].Value = functions.TimesTableArrayFunction(selectedTimesTable)[i, j];
                    }
                    else if (i == j)
                    {
                        grdTimesTable.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    grdTimesTable.Rows[i + 1].Cells[j + 1].Value = functions.TimesTableArrayFunction(selectedTimesTable)[i, j];
                }
            }
        }

        private void CboTimesTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateTable();
        }
    }
}

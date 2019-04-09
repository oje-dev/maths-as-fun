namespace MathsAsFun___Arithmetic_Practise_App
{
    partial class FrmMultiplicationTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMultiplicationTable));
            this.cboTimesTable = new System.Windows.Forms.ComboBox();
            this.grdTimesTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTimesTable
            // 
            this.cboTimesTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimesTable.FormattingEnabled = true;
            this.cboTimesTable.Items.AddRange(new object[] {
            "2 Times Table",
            "3 Times Table",
            "4 Times Table",
            "5 Times Table",
            "6 Times Table",
            "7 Times Table",
            "8 Times Table",
            "9 Times Table",
            "10 Times Table",
            "11 Times Table",
            "12 Times Table"});
            this.cboTimesTable.Location = new System.Drawing.Point(120, 12);
            this.cboTimesTable.MaxDropDownItems = 12;
            this.cboTimesTable.Name = "cboTimesTable";
            this.cboTimesTable.Size = new System.Drawing.Size(121, 21);
            this.cboTimesTable.TabIndex = 0;
            this.cboTimesTable.TabStop = false;
            this.cboTimesTable.SelectedIndexChanged += new System.EventHandler(this.CboTimesTable_SelectedIndexChanged);
            // 
            // grdTimesTable
            // 
            this.grdTimesTable.AllowUserToAddRows = false;
            this.grdTimesTable.AllowUserToDeleteRows = false;
            this.grdTimesTable.AllowUserToResizeColumns = false;
            this.grdTimesTable.AllowUserToResizeRows = false;
            this.grdTimesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdTimesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdTimesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdTimesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTimesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTimesTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTimesTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdTimesTable.Location = new System.Drawing.Point(12, 50);
            this.grdTimesTable.Name = "grdTimesTable";
            this.grdTimesTable.ReadOnly = true;
            this.grdTimesTable.RowHeadersVisible = false;
            this.grdTimesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdTimesTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grdTimesTable.Size = new System.Drawing.Size(334, 318);
            this.grdTimesTable.TabIndex = 1;
            // 
            // FrmMultiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 389);
            this.Controls.Add(this.grdTimesTable);
            this.Controls.Add(this.cboTimesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMultiplicationTable";
            this.ShowInTaskbar = false;
            this.Text = "Multiplication Table";
            this.Load += new System.EventHandler(this.FrmMultiplicationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTimesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimesTable;
        private System.Windows.Forms.DataGridView grdTimesTable;
    }
}
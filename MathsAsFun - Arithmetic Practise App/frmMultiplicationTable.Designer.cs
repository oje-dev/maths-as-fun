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
            this.cboTimesTable = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cboTimesTable.Location = new System.Drawing.Point(184, 12);
            this.cboTimesTable.MaxDropDownItems = 12;
            this.cboTimesTable.Name = "cboTimesTable";
            this.cboTimesTable.Size = new System.Drawing.Size(121, 21);
            this.cboTimesTable.TabIndex = 0;
            this.cboTimesTable.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmMultiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 232);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboTimesTable);
            this.Name = "FrmMultiplicationTable";
            this.Text = "frmMultiplicationTable";
            this.Load += new System.EventHandler(this.FrmMultiplicationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimesTable;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
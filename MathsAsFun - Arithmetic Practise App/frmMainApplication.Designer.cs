namespace MathsAsFun___Arithmetic_Practise_App
{
    partial class frmMainApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainApplication));
            this.cboTimesTable = new System.Windows.Forms.ComboBox();
            this.btnTimesTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTimesTable
            // 
            this.cboTimesTable.FormattingEnabled = true;
            this.cboTimesTable.Items.AddRange(new object[] {
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
            this.cboTimesTable.Location = new System.Drawing.Point(709, 522);
            this.cboTimesTable.Name = "cboTimesTable";
            this.cboTimesTable.Size = new System.Drawing.Size(121, 21);
            this.cboTimesTable.TabIndex = 0;
            // 
            // btnTimesTable
            // 
            this.btnTimesTable.Location = new System.Drawing.Point(709, 549);
            this.btnTimesTable.Name = "btnTimesTable";
            this.btnTimesTable.Size = new System.Drawing.Size(121, 23);
            this.btnTimesTable.TabIndex = 1;
            this.btnTimesTable.Text = "Times Table";
            this.btnTimesTable.UseVisualStyleBackColor = true;
            // 
            // frmMainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.btnTimesTable);
            this.Controls.Add(this.cboTimesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainApplication";
            this.Text = "MathsAsFun - Arithmetic Practise App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainApplication_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainApplication_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimesTable;
        private System.Windows.Forms.Button btnTimesTable;
    }
}
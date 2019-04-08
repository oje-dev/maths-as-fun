namespace MathsAsFun___Arithmetic_Practise_App
{
    partial class FrmMainApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainApplication));
            this.btnTimesTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTimesTable
            // 
            this.btnTimesTable.Location = new System.Drawing.Point(709, 549);
            this.btnTimesTable.Name = "btnTimesTable";
            this.btnTimesTable.Size = new System.Drawing.Size(121, 23);
            this.btnTimesTable.TabIndex = 1;
            this.btnTimesTable.Text = "Times Table";
            this.btnTimesTable.UseVisualStyleBackColor = true;
            this.btnTimesTable.Click += new System.EventHandler(this.BtnTimesTable_Click);
            // 
            // FrmMainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.btnTimesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainApplication";
            this.Text = "MathsAsFun - Arithmetic Practise App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainApplication_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainApplication_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimesTable;
    }
}
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
            this.btnShowTimesTable = new System.Windows.Forms.Button();
            this.lblNeedHelp = new System.Windows.Forms.Label();
            this.rdbPositive = new System.Windows.Forms.RadioButton();
            this.rdbNegative = new System.Windows.Forms.RadioButton();
            this.rdbAddition = new System.Windows.Forms.RadioButton();
            this.rdbSubtraction = new System.Windows.Forms.RadioButton();
            this.rdbMultiplication = new System.Windows.Forms.RadioButton();
            this.rdbDivision = new System.Windows.Forms.RadioButton();
            this.grpPositiveOrNegative = new System.Windows.Forms.GroupBox();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.grpMagnitude = new System.Windows.Forms.GroupBox();
            this.rdbTen = new System.Windows.Forms.RadioButton();
            this.rdbHundred = new System.Windows.Forms.RadioButton();
            this.rdbThousand = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.rdbRelaxedMode = new System.Windows.Forms.RadioButton();
            this.rdbTimedMode = new System.Windows.Forms.RadioButton();
            this.grpPositiveOrNegative.SuspendLayout();
            this.grpOperation.SuspendLayout();
            this.grpMagnitude.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowTimesTable
            // 
            this.btnShowTimesTable.Location = new System.Drawing.Point(747, 549);
            this.btnShowTimesTable.Name = "btnShowTimesTable";
            this.btnShowTimesTable.Size = new System.Drawing.Size(83, 23);
            this.btnShowTimesTable.TabIndex = 1;
            this.btnShowTimesTable.Text = "Show Grid";
            this.btnShowTimesTable.UseVisualStyleBackColor = true;
            this.btnShowTimesTable.Click += new System.EventHandler(this.BtnTimesTable_Click);
            // 
            // lblNeedHelp
            // 
            this.lblNeedHelp.AutoSize = true;
            this.lblNeedHelp.Location = new System.Drawing.Point(494, 554);
            this.lblNeedHelp.Name = "lblNeedHelp";
            this.lblNeedHelp.Size = new System.Drawing.Size(247, 13);
            this.lblNeedHelp.TabIndex = 2;
            this.lblNeedHelp.Text = "Need help? Click here to show a multiplication grid!";
            // 
            // rdbPositive
            // 
            this.rdbPositive.AutoSize = true;
            this.rdbPositive.Location = new System.Drawing.Point(6, 19);
            this.rdbPositive.Name = "rdbPositive";
            this.rdbPositive.Size = new System.Drawing.Size(62, 17);
            this.rdbPositive.TabIndex = 4;
            this.rdbPositive.TabStop = true;
            this.rdbPositive.Text = "Positive";
            this.rdbPositive.UseVisualStyleBackColor = true;
            // 
            // rdbNegative
            // 
            this.rdbNegative.AutoSize = true;
            this.rdbNegative.Location = new System.Drawing.Point(6, 42);
            this.rdbNegative.Name = "rdbNegative";
            this.rdbNegative.Size = new System.Drawing.Size(68, 17);
            this.rdbNegative.TabIndex = 5;
            this.rdbNegative.TabStop = true;
            this.rdbNegative.Text = "Negative";
            this.rdbNegative.UseVisualStyleBackColor = true;
            // 
            // rdbAddition
            // 
            this.rdbAddition.AutoSize = true;
            this.rdbAddition.Location = new System.Drawing.Point(6, 19);
            this.rdbAddition.Name = "rdbAddition";
            this.rdbAddition.Size = new System.Drawing.Size(63, 17);
            this.rdbAddition.TabIndex = 6;
            this.rdbAddition.TabStop = true;
            this.rdbAddition.Text = "Addition";
            this.rdbAddition.UseVisualStyleBackColor = true;
            // 
            // rdbSubtraction
            // 
            this.rdbSubtraction.AutoSize = true;
            this.rdbSubtraction.Location = new System.Drawing.Point(6, 42);
            this.rdbSubtraction.Name = "rdbSubtraction";
            this.rdbSubtraction.Size = new System.Drawing.Size(79, 17);
            this.rdbSubtraction.TabIndex = 7;
            this.rdbSubtraction.TabStop = true;
            this.rdbSubtraction.Text = "Subtraction";
            this.rdbSubtraction.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplication
            // 
            this.rdbMultiplication.AutoSize = true;
            this.rdbMultiplication.Location = new System.Drawing.Point(6, 65);
            this.rdbMultiplication.Name = "rdbMultiplication";
            this.rdbMultiplication.Size = new System.Drawing.Size(86, 17);
            this.rdbMultiplication.TabIndex = 8;
            this.rdbMultiplication.TabStop = true;
            this.rdbMultiplication.Text = "Multiplication";
            this.rdbMultiplication.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new System.Drawing.Point(6, 88);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(62, 17);
            this.rdbDivision.TabIndex = 9;
            this.rdbDivision.TabStop = true;
            this.rdbDivision.Text = "Division";
            this.rdbDivision.UseVisualStyleBackColor = true;
            // 
            // grpPositiveOrNegative
            // 
            this.grpPositiveOrNegative.Controls.Add(this.rdbPositive);
            this.grpPositiveOrNegative.Controls.Add(this.rdbNegative);
            this.grpPositiveOrNegative.Location = new System.Drawing.Point(424, 12);
            this.grpPositiveOrNegative.Name = "grpPositiveOrNegative";
            this.grpPositiveOrNegative.Size = new System.Drawing.Size(200, 70);
            this.grpPositiveOrNegative.TabIndex = 10;
            this.grpPositiveOrNegative.TabStop = false;
            this.grpPositiveOrNegative.Text = "Select Positive or Negative Numbers";
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.rdbAddition);
            this.grpOperation.Controls.Add(this.rdbSubtraction);
            this.grpOperation.Controls.Add(this.rdbDivision);
            this.grpOperation.Controls.Add(this.rdbMultiplication);
            this.grpOperation.Location = new System.Drawing.Point(12, 12);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(200, 112);
            this.grpOperation.TabIndex = 11;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Select Operation";
            // 
            // grpMagnitude
            // 
            this.grpMagnitude.Controls.Add(this.rdbThousand);
            this.grpMagnitude.Controls.Add(this.rdbHundred);
            this.grpMagnitude.Controls.Add(this.rdbTen);
            this.grpMagnitude.Location = new System.Drawing.Point(218, 12);
            this.grpMagnitude.Name = "grpMagnitude";
            this.grpMagnitude.Size = new System.Drawing.Size(200, 89);
            this.grpMagnitude.TabIndex = 12;
            this.grpMagnitude.TabStop = false;
            this.grpMagnitude.Text = "Select Number Magnitude";
            // 
            // rdbTen
            // 
            this.rdbTen.AutoSize = true;
            this.rdbTen.Location = new System.Drawing.Point(7, 20);
            this.rdbTen.Name = "rdbTen";
            this.rdbTen.Size = new System.Drawing.Size(49, 17);
            this.rdbTen.TabIndex = 0;
            this.rdbTen.TabStop = true;
            this.rdbTen.Text = "Tens";
            this.rdbTen.UseVisualStyleBackColor = true;
            // 
            // rdbHundred
            // 
            this.rdbHundred.AutoSize = true;
            this.rdbHundred.Location = new System.Drawing.Point(7, 42);
            this.rdbHundred.Name = "rdbHundred";
            this.rdbHundred.Size = new System.Drawing.Size(71, 17);
            this.rdbHundred.TabIndex = 1;
            this.rdbHundred.TabStop = true;
            this.rdbHundred.Text = "Hundreds";
            this.rdbHundred.UseVisualStyleBackColor = true;
            // 
            // rdbThousand
            // 
            this.rdbThousand.AutoSize = true;
            this.rdbThousand.Location = new System.Drawing.Point(7, 65);
            this.rdbThousand.Name = "rdbThousand";
            this.rdbThousand.Size = new System.Drawing.Size(78, 17);
            this.rdbThousand.TabIndex = 2;
            this.rdbThousand.TabStop = true;
            this.rdbThousand.Text = "Thousands";
            this.rdbThousand.UseVisualStyleBackColor = true;
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rdbTimedMode);
            this.grpMode.Controls.Add(this.rdbRelaxedMode);
            this.grpMode.Location = new System.Drawing.Point(631, 13);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(200, 69);
            this.grpMode.TabIndex = 13;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Select Mode";
            // 
            // rdbRelaxedMode
            // 
            this.rdbRelaxedMode.AutoSize = true;
            this.rdbRelaxedMode.Location = new System.Drawing.Point(6, 18);
            this.rdbRelaxedMode.Name = "rdbRelaxedMode";
            this.rdbRelaxedMode.Size = new System.Drawing.Size(94, 17);
            this.rdbRelaxedMode.TabIndex = 0;
            this.rdbRelaxedMode.TabStop = true;
            this.rdbRelaxedMode.Text = "Relaxed Mode";
            this.rdbRelaxedMode.UseVisualStyleBackColor = true;
            // 
            // rdbTimedMode
            // 
            this.rdbTimedMode.AutoSize = true;
            this.rdbTimedMode.Location = new System.Drawing.Point(6, 41);
            this.rdbTimedMode.Name = "rdbTimedMode";
            this.rdbTimedMode.Size = new System.Drawing.Size(84, 17);
            this.rdbTimedMode.TabIndex = 1;
            this.rdbTimedMode.TabStop = true;
            this.rdbTimedMode.Text = "Timed Mode";
            this.rdbTimedMode.UseVisualStyleBackColor = true;
            // 
            // FrmMainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.grpMagnitude);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpPositiveOrNegative);
            this.Controls.Add(this.lblNeedHelp);
            this.Controls.Add(this.btnShowTimesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainApplication";
            this.Text = "MathsAsFun - Arithmetic Practise App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainApplication_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainApplication_Load);
            this.grpPositiveOrNegative.ResumeLayout(false);
            this.grpPositiveOrNegative.PerformLayout();
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            this.grpMagnitude.ResumeLayout(false);
            this.grpMagnitude.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowTimesTable;
        private System.Windows.Forms.Label lblNeedHelp;
        private System.Windows.Forms.RadioButton rdbPositive;
        private System.Windows.Forms.RadioButton rdbNegative;
        private System.Windows.Forms.RadioButton rdbAddition;
        private System.Windows.Forms.RadioButton rdbSubtraction;
        private System.Windows.Forms.RadioButton rdbMultiplication;
        private System.Windows.Forms.RadioButton rdbDivision;
        private System.Windows.Forms.GroupBox grpPositiveOrNegative;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.GroupBox grpMagnitude;
        private System.Windows.Forms.RadioButton rdbThousand;
        private System.Windows.Forms.RadioButton rdbHundred;
        private System.Windows.Forms.RadioButton rdbTen;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton rdbTimedMode;
        private System.Windows.Forms.RadioButton rdbRelaxedMode;
    }
}
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
            this.components = new System.ComponentModel.Container();
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
            this.rdbThousand = new System.Windows.Forms.RadioButton();
            this.rdbHundred = new System.Windows.Forms.RadioButton();
            this.rdbTen = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.rdbTimedMode = new System.Windows.Forms.RadioButton();
            this.rdbRelaxedMode = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.tmrTimedMode = new System.Windows.Forms.Timer(this.components);
            this.lblTimerText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.imgGreenTick = new System.Windows.Forms.PictureBox();
            this.pnlFirstNumber = new System.Windows.Forms.Panel();
            this.pnlSecondNumber = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.imgInAppLogo = new System.Windows.Forms.PictureBox();
            this.grpPositiveOrNegative.SuspendLayout();
            this.grpOperation.SuspendLayout();
            this.grpMagnitude.SuspendLayout();
            this.grpMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGreenTick)).BeginInit();
            this.pnlFirstNumber.SuspendLayout();
            this.pnlSecondNumber.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowTimesTable
            // 
            this.btnShowTimesTable.Location = new System.Drawing.Point(460, 39);
            this.btnShowTimesTable.Name = "btnShowTimesTable";
            this.btnShowTimesTable.Size = new System.Drawing.Size(244, 23);
            this.btnShowTimesTable.TabIndex = 1;
            this.btnShowTimesTable.Text = "Show Grid";
            this.btnShowTimesTable.UseVisualStyleBackColor = true;
            this.btnShowTimesTable.Click += new System.EventHandler(this.BtnTimesTable_Click);
            // 
            // lblNeedHelp
            // 
            this.lblNeedHelp.AutoSize = true;
            this.lblNeedHelp.Location = new System.Drawing.Point(457, 21);
            this.lblNeedHelp.Name = "lblNeedHelp";
            this.lblNeedHelp.Size = new System.Drawing.Size(247, 13);
            this.lblNeedHelp.TabIndex = 0;
            this.lblNeedHelp.Text = "Need help? Click here to show a multiplication grid!";
            // 
            // rdbPositive
            // 
            this.rdbPositive.AutoSize = true;
            this.rdbPositive.Checked = true;
            this.rdbPositive.Location = new System.Drawing.Point(6, 19);
            this.rdbPositive.Name = "rdbPositive";
            this.rdbPositive.Size = new System.Drawing.Size(86, 17);
            this.rdbPositive.TabIndex = 0;
            this.rdbPositive.TabStop = true;
            this.rdbPositive.Text = "Only Positive";
            this.rdbPositive.UseVisualStyleBackColor = true;
            // 
            // rdbNegative
            // 
            this.rdbNegative.AutoSize = true;
            this.rdbNegative.Location = new System.Drawing.Point(5, 42);
            this.rdbNegative.Name = "rdbNegative";
            this.rdbNegative.Size = new System.Drawing.Size(106, 17);
            this.rdbNegative.TabIndex = 1;
            this.rdbNegative.Text = "Include Negative";
            this.rdbNegative.UseVisualStyleBackColor = true;
            // 
            // rdbAddition
            // 
            this.rdbAddition.AutoSize = true;
            this.rdbAddition.Checked = true;
            this.rdbAddition.Location = new System.Drawing.Point(6, 19);
            this.rdbAddition.Name = "rdbAddition";
            this.rdbAddition.Size = new System.Drawing.Size(63, 17);
            this.rdbAddition.TabIndex = 0;
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
            this.rdbSubtraction.TabIndex = 1;
            this.rdbSubtraction.Text = "Subtraction";
            this.rdbSubtraction.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplication
            // 
            this.rdbMultiplication.AutoSize = true;
            this.rdbMultiplication.Location = new System.Drawing.Point(6, 65);
            this.rdbMultiplication.Name = "rdbMultiplication";
            this.rdbMultiplication.Size = new System.Drawing.Size(86, 17);
            this.rdbMultiplication.TabIndex = 2;
            this.rdbMultiplication.Text = "Multiplication";
            this.rdbMultiplication.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new System.Drawing.Point(6, 88);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(62, 17);
            this.rdbDivision.TabIndex = 3;
            this.rdbDivision.Text = "Division";
            this.rdbDivision.UseVisualStyleBackColor = true;
            // 
            // grpPositiveOrNegative
            // 
            this.grpPositiveOrNegative.Controls.Add(this.rdbPositive);
            this.grpPositiveOrNegative.Controls.Add(this.rdbNegative);
            this.grpPositiveOrNegative.Location = new System.Drawing.Point(504, 85);
            this.grpPositiveOrNegative.Name = "grpPositiveOrNegative";
            this.grpPositiveOrNegative.Size = new System.Drawing.Size(200, 70);
            this.grpPositiveOrNegative.TabIndex = 4;
            this.grpPositiveOrNegative.TabStop = false;
            this.grpPositiveOrNegative.Text = "Include Negative Numbers?";
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.rdbAddition);
            this.grpOperation.Controls.Add(this.rdbSubtraction);
            this.grpOperation.Controls.Add(this.rdbDivision);
            this.grpOperation.Controls.Add(this.rdbMultiplication);
            this.grpOperation.Location = new System.Drawing.Point(12, 85);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(200, 123);
            this.grpOperation.TabIndex = 2;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Select Operation";
            // 
            // grpMagnitude
            // 
            this.grpMagnitude.Controls.Add(this.rdbThousand);
            this.grpMagnitude.Controls.Add(this.rdbHundred);
            this.grpMagnitude.Controls.Add(this.rdbTen);
            this.grpMagnitude.Location = new System.Drawing.Point(256, 85);
            this.grpMagnitude.Name = "grpMagnitude";
            this.grpMagnitude.Size = new System.Drawing.Size(204, 123);
            this.grpMagnitude.TabIndex = 3;
            this.grpMagnitude.TabStop = false;
            this.grpMagnitude.Text = "Select Magnitude";
            // 
            // rdbThousand
            // 
            this.rdbThousand.AutoSize = true;
            this.rdbThousand.Location = new System.Drawing.Point(7, 65);
            this.rdbThousand.Name = "rdbThousand";
            this.rdbThousand.Size = new System.Drawing.Size(71, 17);
            this.rdbThousand.TabIndex = 2;
            this.rdbThousand.Text = "Hundreds";
            this.rdbThousand.UseVisualStyleBackColor = true;
            // 
            // rdbHundred
            // 
            this.rdbHundred.AutoSize = true;
            this.rdbHundred.Location = new System.Drawing.Point(7, 42);
            this.rdbHundred.Name = "rdbHundred";
            this.rdbHundred.Size = new System.Drawing.Size(49, 17);
            this.rdbHundred.TabIndex = 1;
            this.rdbHundred.Text = "Tens";
            this.rdbHundred.UseVisualStyleBackColor = true;
            // 
            // rdbTen
            // 
            this.rdbTen.AutoSize = true;
            this.rdbTen.Checked = true;
            this.rdbTen.Location = new System.Drawing.Point(7, 20);
            this.rdbTen.Name = "rdbTen";
            this.rdbTen.Size = new System.Drawing.Size(49, 17);
            this.rdbTen.TabIndex = 0;
            this.rdbTen.TabStop = true;
            this.rdbTen.Text = "Units";
            this.rdbTen.UseVisualStyleBackColor = true;
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rdbTimedMode);
            this.grpMode.Controls.Add(this.rdbRelaxedMode);
            this.grpMode.Location = new System.Drawing.Point(504, 161);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(200, 47);
            this.grpMode.TabIndex = 5;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Select Mode";
            // 
            // rdbTimedMode
            // 
            this.rdbTimedMode.AutoSize = true;
            this.rdbTimedMode.Location = new System.Drawing.Point(110, 19);
            this.rdbTimedMode.Name = "rdbTimedMode";
            this.rdbTimedMode.Size = new System.Drawing.Size(84, 17);
            this.rdbTimedMode.TabIndex = 1;
            this.rdbTimedMode.Text = "Timed Mode";
            this.rdbTimedMode.UseVisualStyleBackColor = true;
            // 
            // rdbRelaxedMode
            // 
            this.rdbRelaxedMode.AutoSize = true;
            this.rdbRelaxedMode.Checked = true;
            this.rdbRelaxedMode.Location = new System.Drawing.Point(6, 18);
            this.rdbRelaxedMode.Name = "rdbRelaxedMode";
            this.rdbRelaxedMode.Size = new System.Drawing.Size(94, 17);
            this.rdbRelaxedMode.TabIndex = 0;
            this.rdbRelaxedMode.TabStop = true;
            this.rdbRelaxedMode.Text = "Relaxed Mode";
            this.rdbRelaxedMode.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 224);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 32);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Practise!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(370, 221);
            this.txtAnswer.MaxLength = 8;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(171, 39);
            this.txtAnswer.TabIndex = 11;
            this.txtAnswer.Visible = false;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAnswer_KeyDown);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(547, 224);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(165, 32);
            this.lblIncorrect.TabIndex = 13;
            this.lblIncorrect.Text = "-99980001!";
            this.lblIncorrect.Visible = false;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblFirstNumber.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.Location = new System.Drawing.Point(3, 0);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(75, 32);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "9999";
            this.lblFirstNumber.Visible = false;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblSecondNumber.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.Location = new System.Drawing.Point(5, 0);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(75, 32);
            this.lblSecondNumber.TabIndex = 0;
            this.lblSecondNumber.Text = "9999";
            this.lblSecondNumber.Visible = false;
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.SystemColors.Control;
            this.lblOperator.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblOperator.Location = new System.Drawing.Point(206, 224);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(32, 36);
            this.lblOperator.TabIndex = 8;
            this.lblOperator.Text = "x";
            this.lblOperator.Visible = false;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.BackColor = System.Drawing.SystemColors.Control;
            this.lblEquals.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(334, 224);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(30, 32);
            this.lblEquals.TabIndex = 10;
            this.lblEquals.Text = "=";
            this.lblEquals.Visible = false;
            // 
            // tmrTimedMode
            // 
            this.tmrTimedMode.Interval = 1000;
            this.tmrTimedMode.Tick += new System.EventHandler(this.TmrTimedMode_Tick);
            // 
            // lblTimerText
            // 
            this.lblTimerText.AutoSize = true;
            this.lblTimerText.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerText.Location = new System.Drawing.Point(570, 276);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(77, 28);
            this.lblTimerText.TabIndex = 15;
            this.lblTimerText.Text = "Time:";
            this.lblTimerText.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(51, 28);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "210";
            this.lblTimer.Visible = false;
            // 
            // imgGreenTick
            // 
            this.imgGreenTick.Image = ((System.Drawing.Image)(resources.GetObject("imgGreenTick.Image")));
            this.imgGreenTick.Location = new System.Drawing.Point(547, 221);
            this.imgGreenTick.Name = "imgGreenTick";
            this.imgGreenTick.Size = new System.Drawing.Size(40, 39);
            this.imgGreenTick.TabIndex = 24;
            this.imgGreenTick.TabStop = false;
            this.imgGreenTick.Visible = false;
            // 
            // pnlFirstNumber
            // 
            this.pnlFirstNumber.Controls.Add(this.lblFirstNumber);
            this.pnlFirstNumber.Location = new System.Drawing.Point(120, 224);
            this.pnlFirstNumber.Name = "pnlFirstNumber";
            this.pnlFirstNumber.Size = new System.Drawing.Size(80, 32);
            this.pnlFirstNumber.TabIndex = 7;
            // 
            // pnlSecondNumber
            // 
            this.pnlSecondNumber.Controls.Add(this.lblSecondNumber);
            this.pnlSecondNumber.Location = new System.Drawing.Point(244, 224);
            this.pnlSecondNumber.Name = "pnlSecondNumber";
            this.pnlSecondNumber.Size = new System.Drawing.Size(84, 32);
            this.pnlSecondNumber.TabIndex = 9;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 273);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(90, 32);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "Score";
            this.lblScore.Visible = false;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Location = new System.Drawing.Point(653, 276);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(51, 28);
            this.pnlTimer.TabIndex = 28;
            // 
            // imgInAppLogo
            // 
            this.imgInAppLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgInAppLogo.Image")));
            this.imgInAppLogo.Location = new System.Drawing.Point(12, 12);
            this.imgInAppLogo.Name = "imgInAppLogo";
            this.imgInAppLogo.Size = new System.Drawing.Size(439, 58);
            this.imgInAppLogo.TabIndex = 29;
            this.imgInAppLogo.TabStop = false;
            // 
            // FrmMainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 316);
            this.Controls.Add(this.imgInAppLogo);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlSecondNumber);
            this.Controls.Add(this.pnlFirstNumber);
            this.Controls.Add(this.imgGreenTick);
            this.Controls.Add(this.lblTimerText);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.grpMagnitude);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpPositiveOrNegative);
            this.Controls.Add(this.lblNeedHelp);
            this.Controls.Add(this.btnShowTimesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainApplication";
            this.Text = "MathsAsFun - Arithmetic Practise App";
            this.Activated += new System.EventHandler(this.FrmMainApplication_Activated);
            this.Deactivate += new System.EventHandler(this.FrmMainApplication_Deactivate);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgGreenTick)).EndInit();
            this.pnlFirstNumber.ResumeLayout(false);
            this.pnlFirstNumber.PerformLayout();
            this.pnlSecondNumber.ResumeLayout(false);
            this.pnlSecondNumber.PerformLayout();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInAppLogo)).EndInit();
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Timer tmrTimedMode;
        private System.Windows.Forms.Label lblTimerText;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox imgGreenTick;
        private System.Windows.Forms.Panel pnlFirstNumber;
        private System.Windows.Forms.Panel pnlSecondNumber;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.PictureBox imgInAppLogo;
    }
}
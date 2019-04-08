namespace MathsAsFun___Arithmetic_Practise_App
{
    partial class FrmLoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadingScreen));
            this.tmrLoadingScreen = new System.Windows.Forms.Timer(this.components);
            this.lblCopyrightMessage = new System.Windows.Forms.Label();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.tmrProgressBar = new System.Windows.Forms.Timer(this.components);
            this.imgPi = new System.Windows.Forms.PictureBox();
            this.imgSigma = new System.Windows.Forms.PictureBox();
            this.imgTheta = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLoadingScreen
            // 
            this.tmrLoadingScreen.Interval = 10;
            this.tmrLoadingScreen.Tick += new System.EventHandler(this.TmrLoadingScreen_Tick);
            // 
            // lblCopyrightMessage
            // 
            this.lblCopyrightMessage.AutoSize = true;
            this.lblCopyrightMessage.Location = new System.Drawing.Point(184, 357);
            this.lblCopyrightMessage.Name = "lblCopyrightMessage";
            this.lblCopyrightMessage.Size = new System.Drawing.Size(264, 13);
            this.lblCopyrightMessage.TabIndex = 0;
            this.lblCopyrightMessage.Text = "Copyright © 2019 MathsAsFun, inc. All rights reserved.";
            // 
            // prgLoading
            // 
            this.prgLoading.Location = new System.Drawing.Point(12, 318);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(608, 23);
            this.prgLoading.TabIndex = 2;
            // 
            // tmrProgressBar
            // 
            this.tmrProgressBar.Enabled = true;
            this.tmrProgressBar.Interval = 300;
            this.tmrProgressBar.Tick += new System.EventHandler(this.TmrProgressBar_Tick);
            // 
            // imgPi
            // 
            this.imgPi.Enabled = false;
            this.imgPi.Image = ((System.Drawing.Image)(resources.GetObject("imgPi.Image")));
            this.imgPi.Location = new System.Drawing.Point(12, 12);
            this.imgPi.Name = "imgPi";
            this.imgPi.Size = new System.Drawing.Size(300, 300);
            this.imgPi.TabIndex = 3;
            this.imgPi.TabStop = false;
            this.imgPi.Visible = false;
            // 
            // imgSigma
            // 
            this.imgSigma.Enabled = false;
            this.imgSigma.Image = ((System.Drawing.Image)(resources.GetObject("imgSigma.Image")));
            this.imgSigma.Location = new System.Drawing.Point(640, 12);
            this.imgSigma.Name = "imgSigma";
            this.imgSigma.Size = new System.Drawing.Size(300, 300);
            this.imgSigma.TabIndex = 4;
            this.imgSigma.TabStop = false;
            this.imgSigma.Visible = false;
            // 
            // imgTheta
            // 
            this.imgTheta.Enabled = false;
            this.imgTheta.Image = ((System.Drawing.Image)(resources.GetObject("imgTheta.Image")));
            this.imgTheta.Location = new System.Drawing.Point(326, 12);
            this.imgTheta.Name = "imgTheta";
            this.imgTheta.Size = new System.Drawing.Size(300, 300);
            this.imgTheta.TabIndex = 5;
            this.imgTheta.TabStop = false;
            this.imgTheta.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(865, 322);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 39);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(608, 273);
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            // 
            // frmLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 379);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.prgLoading);
            this.Controls.Add(this.lblCopyrightMessage);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.imgTheta);
            this.Controls.Add(this.imgSigma);
            this.Controls.Add(this.imgPi);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoadingScreen";
            this.ShowInTaskbar = false;
            this.Text = "Arithmetic Practise App - Welcome Screen";
            this.Load += new System.EventHandler(this.FrmLoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrLoadingScreen;
        private System.Windows.Forms.Label lblCopyrightMessage;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Timer tmrProgressBar;
        private System.Windows.Forms.PictureBox imgPi;
        private System.Windows.Forms.PictureBox imgSigma;
        private System.Windows.Forms.PictureBox imgTheta;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}


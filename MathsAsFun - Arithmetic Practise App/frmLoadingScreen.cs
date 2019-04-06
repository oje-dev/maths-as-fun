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
    public partial class frmLoadingScreen : Form
    {
        int timeElapsed = 0;

        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void FrmLoadingScreen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void TmrProgressBar_Tick(object sender, EventArgs e)
        {
            if (prgLoading.Value == 80)
            {
                prgLoading.Value = 100;
                tmrProgressBar.Enabled = false;
                tmrLoadingScreen.Enabled = true;
            }
            else
            {
                prgLoading.Value += 2;
            }
        }

        private void TmrLoadingScreen_Tick(object sender, EventArgs e)
        {
            switch (timeElapsed)
            {
                case 1000:
                    imgLogo.Visible = false;
                    prgLoading.Visible = false;
                    lblCopyrightMessage.Visible = false;
                    Cursor = default;
                    ShowInTaskbar = true;
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    Width = 965;
                    Height = 395;
                    Location = new Point(Location.X - 200, Location.Y - 100);
                    break;
                case 1010:
                    imgPi.Visible = true;
                    imgPi.Enabled = true;
                    break;
                case 3850:
                    imgTheta.Enabled = true;
                    imgTheta.Visible = true;
                    break;
                case 6800:
                    imgSigma.Enabled = true;
                    imgSigma.Visible = true;
                    break;
                case 6900:
                    imgPi.Enabled = false;
                    imgPi.Visible = false;
                    break;
                case 9900:
                    imgTheta.Enabled = false;
                    imgTheta.Visible = false;
                    break;
                case 11500:
                    imgSigma.Enabled = false;
                    imgSigma.Visible = false;
                    btnContinue.Visible = true;
                    timeElapsed = 1000;
                    break;
            }
            timeElapsed += 10;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            tmrLoadingScreen.Enabled = false;
            tmrLoadingScreen.Dispose();
            Hide();
            frmMainApplication frmMain = new frmMainApplication();
            frmMain.Show();
        }
    }
}

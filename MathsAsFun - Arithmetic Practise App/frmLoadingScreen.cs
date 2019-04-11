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
    public partial class FrmLoadingScreen : Form
    {
        private static int timeElapsed = 0; //A class variable since it is used by multiple methods within this class.

        public FrmLoadingScreen()
        {
            InitializeComponent();
        }

        private void FrmLoadingScreen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void TmrProgressBar_Tick(object sender, EventArgs e) //Fills up the progress bar randomly as the timer ticks and starts tmrLoadingScreen when the progress bar is full.
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
            switch (timeElapsed) //Dictates what events occur at set intervals of time.
            {
                case 1000: //After one second the entire look of the form is changed to give the appearance that a new form has been opened.
                    imgLogo.Visible = false;
                    prgLoading.Visible = false;
                    Cursor = default;
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    Width = 965;
                    Height = 395;
                    lblCopyrightMessage.Left = (ClientSize.Width - lblCopyrightMessage.Width) / 2;
                    lblCopyrightMessage.Top = (ClientSize.Height - lblCopyrightMessage.Height) - 10;
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
                    btnContinue.Enabled = true;
                    timeElapsed = 1000;
                    break;
            }
            timeElapsed += 10;
        }

        private void BtnContinue_Click(object sender, EventArgs e) //Button hides the loading screen form when clicked and shows the main form.
        {
            tmrLoadingScreen.Enabled = false;
            tmrLoadingScreen.Dispose();
            Hide();
            FrmMainApplication frmMainApplication = new FrmMainApplication();
            frmMainApplication.Show();
        }
    }
}

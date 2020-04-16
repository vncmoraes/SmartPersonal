using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPersonal.View
{
    public partial class frmSplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public frmSplashScreen()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (pbSplash.Value <= 90)
            {
                pbSplash.Value += 10;
            }
            else
            {
                timerSplash.Enabled = false;
                this.Hide();

                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }

    }
}

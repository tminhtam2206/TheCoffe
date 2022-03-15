using DTH175190_TheCoffeHouse.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTH175190_TheCoffeHouse.GUI
{
    public partial class fSetting : Form
    {
        public fSetting()
        {
            InitializeComponent();
        }

        #region Move Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void fSetting_Load(object sender, EventArgs e)
        {
            switchTopMost.Value = SystemApp.TopMost;
            btnHienWindowControl.Value = SystemApp.WindowControl;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchTopMost_OnValuechange(object sender, EventArgs e)
        {
            if (switchTopMost.Value)
            {
                SystemApp.TopMost = true;
                lbTopMost.Text = "Đang bật";
                SystemApp.LOAD_DATA = true;
            }
            else
            {
                SystemApp.TopMost = false;
                lbTopMost.Text = "Đang tắt";
                SystemApp.LOAD_DATA = true;
            }
        }

        private void btnHienWindowControl_OnValuechange(object sender, EventArgs e)
        {
            if (btnHienWindowControl.Value)
            {
                SystemApp.WindowControl = true;
                lbHienWindowControl.Text = "Đang bật";
                SystemApp.LOAD_DATA = true;
            }
            else
            {
                SystemApp.WindowControl = false;
                lbHienWindowControl.Text = "Đang tắt";
                SystemApp.LOAD_DATA = true;
            }
        }

        private void btnSpeedMode_OnValuechange(object sender, EventArgs e)
        {
            if (btnSpeedMode.Value)
            {
                SystemApp.SpeedMode = true;
                lbSpeedMode.Text = "Đang bật";
                SystemApp.LOAD_DATA = true;
            }
            else
            {
                SystemApp.SpeedMode = false;
                lbSpeedMode.Text = "Đang tắt";
                SystemApp.LOAD_DATA = true;
            }
        }
    }
}

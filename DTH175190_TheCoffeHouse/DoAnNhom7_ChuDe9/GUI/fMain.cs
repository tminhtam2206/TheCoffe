using DTH175190_TheCoffeHouse.BUS;
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
    public partial class fMain : Form
    {
        public fMain()
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

        private void fMain_Load(object sender, EventArgs e)
        {
            LoadSetting();

            if (SystemApp.Avatar != null)
                picUser.Image = SystemApp.Avatar;
        }


        #region Events
        private void btnMiniMumSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show("Bạn có muốn đăng xuất?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }


        #endregion

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new fSetting().ShowDialog();
        }

        private void timerSetting_Tick(object sender, EventArgs e)
        {
            if (SystemApp.LOAD_DATA)
                LoadSetting();
            
        }

        private void LoadSetting()
        {
            if (SystemApp.WindowControl)
            {
                pnlMenuSystem.Visible = true;
                pnlMenuSystem.Location = new Point(1210, 2);

                pnlWelcomUser.Location = new Point(879, 2);
                pnlGroupSetting.Location = new Point(750, 3);
            }
            else
            {
                pnlMenuSystem.Visible = false;

                pnlWelcomUser.Location = new Point(1000, 2);
                pnlGroupSetting.Location = new Point(870, 2);
            }

            if (SystemApp.TopMost)
                this.TopMost = true;
            else
                this.TopMost = false;

            lbUserName.Text = SystemApp.DisplayName;

            if (SystemApp.Type == 0)
                lbPhanQuyen.Text = "Administrator";
            else
                lbPhanQuyen.Text = "Staff";

            picUser.Image = SystemApp.Avatar;

            SystemApp.LOAD_DATA = false;
        }

        private void btnMaximumSize_Click(object sender, EventArgs e)
        {
            if (btnMaximumSize.BackColor == Color.FromArgb(13, 93, 142))
            {
                btnMaximumSize.BackColor = Color.FromArgb(12, 93, 142);
                SystemApp.lx = this.Location.X;
                SystemApp.ly = this.Location.Y;
                SystemApp.sw = this.Size.Width;
                SystemApp.sh = this.Size.Height;

                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
            else
            {
                btnMaximumSize.BackColor = Color.FromArgb(13, 93, 142);
                this.Size = new Size(SystemApp.sw, SystemApp.sh);
                this.Location = new Point(SystemApp.lx, SystemApp.ly);
            }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            MyMessageBox.Show("Tính năng này hiện còn đang phát triển!", MessageBoxButtons.OK);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (!SystemApp.StatusMenu_Main)
            {
                pnlControlLeft.Width -= 2;

                if (pnlControlLeft.Width <= 47)
                {
                    SystemApp.StatusMenu_Main = true;
                    timerMenu.Stop();
                }
            }
            else
            {
                pnlControlLeft.Width += 2;

                if (pnlControlLeft.Width >= 177)
                {
                    SystemApp.StatusMenu_Main = false;
                    timerMenu.Stop();
                }
            }
        }

        private void btnInfoAccount_Click(object sender, EventArgs e)
        {
            new fAccountInfo().ShowDialog();
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            BUS_LoginAccount.ShowAvatar(SystemApp.User);
        }

        private void picUser_DoubleClick(object sender, EventArgs e)
        {
            new fAccountInfo().ShowDialog();
        }

    }
}

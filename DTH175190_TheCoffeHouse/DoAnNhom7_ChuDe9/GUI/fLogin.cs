using DTH175190_TheCoffeHouse;
using DTH175190_TheCoffeHouse.BUS;
using DTH175190_TheCoffeHouse.General;
using DTH175190_TheCoffeHouse.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTH175190_TheCoffeHouse
{
    public partial class fLogin : Form
    {
        public fLogin()
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

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show("Bạn có muốn thoát chương trình?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUser.Text.Length == 0 || txbPass.Text.Length == 0)
                MyMessageBox.Show("Tên đăng nhập hoặc mật khẩu bị trống!", MessageBoxButtons.OK);
            else
            {
                if (BUS_LoginAccount.Login(txbUser.Text, txbPass.Text))
                {
                    if (!ckbRemember.Checked)
                        txbPass.Clear();

                    BUS_LoginAccount.ShowAvatar(txbUser.Text);
                    BUS_Actions.AddActions(txbUser.Text, "Đăng nhập");

                    fMain f = new fMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                    MyMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", MessageBoxButtons.OK);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!SystemApp.ViewPass)
            {
                SystemApp.ViewPass = true;
                btnView.Image = Properties.Resources.visible_black;
            }
            else
            {
                SystemApp.ViewPass = false;
                btnView.Image = Properties.Resources.invisible_black;
            }
        }

        private void timerApp_Tick(object sender, EventArgs e)
        {
            if (txbPass.Text.Length == 0)
                txbPass.UseSystemPasswordChar = false;
            else
            {
                if (SystemApp.ViewPass)
                    txbPass.UseSystemPasswordChar = false;
                else
                    txbPass.UseSystemPasswordChar = true;
            }
        }
        #endregion


    }
}

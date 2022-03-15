using DTH175190_TheCoffeHouse.BUS;
using DTH175190_TheCoffeHouse.DTO;
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
    public partial class fAccountInfo : Form
    {
        private string imgLocation = "";

        public fAccountInfo()
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

        private void fAccountInfo_Load(object sender, EventArgs e)
        {
            txbOldDisplayName.Text = SystemApp.DisplayName;

            ShowTimeLine();



            if (picAvartar.Image != null)
                picAvartar.Image = SystemApp.Avatar;
            
        }

        private void ShowTimeLine()
        {
            this.dgvTimeLine.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.dgvTimeLine.EnableHeadersVisualStyles = false;
            List<DTO_Actions> listTimeLine = BUS_Actions.ShowAction(SystemApp.User);
            dgvTimeLine.DataSource = listTimeLine;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Chọn ảnh đại diện";

            if (SystemApp.Type == 0)
                open.Filter = "Ảnh PNG (*.png)|*.png|Ảnh JPG (*.jpg)|*.jpg|Ảnh JPEG (*.jpeg)|*.jpeg|Ảnh GIF (*.gif)|*.gif|All files (*.*)|*.*";
            else
                open.Filter = "Ảnh PNG (*.png)|*.png|Ảnh JPG (*.jpg)|*.jpg|Ảnh JPEG (*.jpeg)|*.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imgLocation = open.FileName;
                picAvartar.ImageLocation = imgLocation;
                this.Cursor = Cursors.WaitCursor;

                if (BUS_LoginAccount.SetAvatar(imgLocation, SystemApp.User))
                {
                    BUS_Actions.AddActions(SystemApp.User, "Đổi avatar");
                    ShowTimeLine();
                    MyMessageBox.Show("Thay đổi Avatar thành công!", MessageBoxButtons.OK);
                    SystemApp.Avatar = picAvartar.Image;
                    SystemApp.LOAD_DATA = true;
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MyMessageBox.Show("Thay đổi Avatar thất bại!", MessageBoxButtons.OK);
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbOldPass_TextChanged(object sender, EventArgs e)
        {
            if (txbOldPass.Text.Length == 0)
                txbOldPass.UseSystemPasswordChar = false;
            else
                txbOldPass.UseSystemPasswordChar = true;
        }

        private void txbNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txbNewPass.Text.Length == 0)
                txbNewPass.UseSystemPasswordChar = false;
            else
                txbNewPass.UseSystemPasswordChar = true;
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            if(txbOldPass.Text.Length == 0 || txbNewPass.Text.Length == 0)
                MyMessageBox.Show("Mật khẩu không được bỏ trống!", MessageBoxButtons.OK);
            else if (txbOldPass.Text != SystemApp.Pass)
                MyMessageBox.Show("Mật khẩu cũ không đúng!", MessageBoxButtons.OK);
            else
            {
                try
                {
                    if (BUS_LoginAccount.UpdatePassword(txbNewPass.Text, SystemApp.User))
                    {
                        BUS_Actions.AddActions(SystemApp.User, "Đổi mật khẩu");
                        ShowTimeLine();
                        MyMessageBox.Show("Thay đổi mật khẩu thành công!", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MyMessageBox.Show("Thay đổi mật khẩu thất bại!", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUpdateDisplayName_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUS_LoginAccount.UpdateDisplayName(txbNewDisplayName.Text, SystemApp.User))
                {
                    BUS_Actions.AddActions(SystemApp.User, "Đổi tên hiển thị");
                    ShowTimeLine();
                    MyMessageBox.Show("Thay đổi tên hiển thị thành công!", MessageBoxButtons.OK);
                    SystemApp.DisplayName = txbNewDisplayName.Text;
                    SystemApp.LOAD_DATA = true;
                }
            }
            catch
            {
                MyMessageBox.Show("Thay đổi tên hiển thị thất bại!", MessageBoxButtons.OK);
            }
        }
    }
}

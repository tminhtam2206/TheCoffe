using DTH175190_TheCoffeHouse.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTH175190_TheCoffeHouse.DAO
{
    public class DAO_LoginAcount
    {
        public static bool Login(string user, string pass)
        {
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(tmp);
            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.ExecuteQuery(query, new object[] { user, hasPass });

            if (result.Rows.Count > 0)
            {
                SystemApp.User = user;
                SystemApp.Pass = pass;

                foreach (DataRow item in result.Rows)
                {
                    SystemApp.DisplayName = item["DisplayName"].ToString();
                    SystemApp.Type = (int)item["TypeAccount"];
                }

                return true;
            }

            return false;
        }

        public static bool SetAvatar(string imgLocation, string Username)
        {
            byte[] image = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            image = brs.ReadBytes((int)stream.Length);

            string query = "update Account set Avatar = @Avatar where Username = @Username";
            int result = DataProvider.ExecuteNonQuery(query, new object[] { image, Username });
            return result > 0;
        }

        public static void ShowAvatar(string Username)
        {
            PictureBox pic = new PictureBox();
            string query = "SELECT Avatar FROM dbo.Account WHERE Username = '"+Username+"'";

            DataTable data = DataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                try
                {
                    byte[] image = ((byte[])item["Avatar"]);
                    if (image == null)
                        pic.Image = null;

                    else
                    {
                        MemoryStream mStream = new MemoryStream(image);
                        SystemApp.Avatar = Image.FromStream(mStream);
                    }
                }
                catch
                {
                    SystemApp.Avatar = null;
                }
            }
        }

        public static bool UpdatePassword(string pass, string user)
        {
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(tmp);
            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            string query = "UPDATE dbo.Account SET Pass = @Pass WHERE Username = @Username";

            int result = DataProvider.ExecuteNonQuery(query, new object[] { hasPass, user });

            return result > 0;
        }

        public static bool UpdateDisplayName(string display, string user)
        {
            string query = "UPDATE dbo.Account SET DisplayName = @DisplayName WHERE Username = @Username";

            int result = DataProvider.ExecuteNonQuery(query, new object[] { display, user });

            return result > 0;
        }
    }
}

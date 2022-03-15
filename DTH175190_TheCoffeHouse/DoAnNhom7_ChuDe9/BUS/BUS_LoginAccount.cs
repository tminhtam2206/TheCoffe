using DTH175190_TheCoffeHouse.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTH175190_TheCoffeHouse.BUS
{
    public class BUS_LoginAccount
    {
        public static bool Login(string user, string pass)
        {
            return DAO_LoginAcount.Login(user, pass);
        }

        public static bool SetAvatar(string imgLocation, string Username)
        {
            return DAO_LoginAcount.SetAvatar(imgLocation, Username);
        }

        public static void ShowAvatar(string Username)
        {
            DAO_LoginAcount.ShowAvatar(Username);
        }

        public static bool UpdatePassword(string pass, string user)
        {
            return DAO_LoginAcount.UpdatePassword(pass, user);
        }

        public static bool UpdateDisplayName(string display, string user)
        {
            return DAO_LoginAcount.UpdateDisplayName(display, user);
        }
    }
}

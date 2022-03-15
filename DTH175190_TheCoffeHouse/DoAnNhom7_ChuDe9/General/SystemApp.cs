using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTH175190_TheCoffeHouse.General
{
    public class SystemApp
    {
        public static bool ViewPass = false;
        public static string User;
        public static string Pass;
        public static string DisplayName;
        public static int Type;
        public static Image Avatar;

        #region Seting
        public static int lx, ly, sw, sh;
        public static string Them = "Light";
        public static bool TopMost = false;
        public static bool WindowControl = false;
        public static bool SpeedMode = false;
        #endregion

        #region FormMain
        public static bool StatusMenu_Main = true;
        public static bool LOAD_DATA = false;
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTH175190_TheCoffeHouse.General
{
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult Show(string message, System.Windows.Forms.MessageBoxButtons button)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (fMess_OK messOK = new fMess_OK())
                    {
                        messOK.Message = message;
                        dlgResult = messOK.ShowDialog();
                    }
                    break;

                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (fMess_YESNO messYESNO = new fMess_YESNO())
                    {
                        messYESNO.Message = message;
                        dlgResult = messYESNO.ShowDialog();
                    }
                    break;
            }

            return dlgResult;
        }
    }
}

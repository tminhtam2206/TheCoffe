using DTH175190_TheCoffeHouse.DAO;
using DTH175190_TheCoffeHouse.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTH175190_TheCoffeHouse.BUS
{
    public class BUS_Actions
    {
        public static void AddActions(string user, string action)
        {
            DAO_Actions.AddActions(user, action);
        }

        public static List<DTO_Actions> ShowAction(string user)
        {
            return DAO_Actions.ShowAction(user);
        }
    }
}

using DTH175190_TheCoffeHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTH175190_TheCoffeHouse.DAO
{
    public class DAO_Actions
    {
        public static void AddActions(string user, string action)
        {
            string query = "INSERT INTO dbo.Actions VALUES  ( @Username , @Action , @CurrTime )";

            DateTime tmp = DateTime.Now;
            string time = tmp.ToString("dd/MM/yyyy HH:mm:ss");

            DataProvider.ExecuteNonQuery(query, new object[] { user, action, time });
        }

        public static List<DTO_Actions> ShowAction(string user)
        {
            List<DTO_Actions> ds = new List<DTO_Actions>();
            DataTable data = DataProvider.ExecuteQuery("SELECT *FROM dbo.Actions WHERE Username = @Username ORDER BY IdAction DESC", new object[] { user });

            foreach (DataRow item in data.Rows)
            {
                DTO_Actions tmp = new DTO_Actions(item);
                ds.Add(tmp);
            }

            return ds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTH175190_TheCoffeHouse.DTO
{
    public class DTO_Actions
    {
        private string action;
        private string currTime;

        public string Action { get => action; set => action = value; }
        public string CurrTime { get => currTime; set => currTime = value; }

        public DTO_Actions(DataRow row)
        {
            this.Action = row["Action"].ToString();
            this.CurrTime = row["CurrTime"].ToString();
        }
    }
}

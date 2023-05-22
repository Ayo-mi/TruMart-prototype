using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruMart.Sell.Util
{
    internal class RowData
    {
        public int Reciept { get; set; }

        public string CustomerName { get; set; }

        public string User { get; set; }

        public string Outlet { get; set; }

        public decimal SalesTotal { get; set; }

        public string Status { get; set; }

        public string Note { get; set; }

        public decimal Paid { get; set; }

        public decimal Balance { get; set; }
    }
}

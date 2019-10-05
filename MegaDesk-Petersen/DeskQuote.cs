using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Petersen
{
    class DeskQuote
    {
        //members
        private string custName;
        private DateTime quoteDate;
        private uint rushOrder;
        private double quoteTotal;

        //methods
        public string CustName { get; set; }
        public uint RushOrder { get; set; }
    }
}

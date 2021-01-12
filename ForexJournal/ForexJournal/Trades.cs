using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexJournal
{
    public class Trades
    {
        public string trade { get; set; }
        public string date { get; set; }
        public string entryTime { get; set; }
        public string exitTime { get; set; }
        public string tradeType { get; set; }
        public string lotSize { get; set; }
        public string entryPrice { get; set; }
        public string exitPrice { get; set; }
        public string pips { get; set; }
        public string profitLost { get; set; }
        public string accountTotal { get; set; }
    }
}

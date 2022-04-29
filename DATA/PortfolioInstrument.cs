using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class PortfolioInstrument
    {
        public string Symbol { get; private set; }
        public decimal AvgPrice { get; private set; }
        public decimal Units { get; private set; }
    }
}

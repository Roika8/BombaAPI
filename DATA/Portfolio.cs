using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Portfolio
    {
        public User User { get; private set; }
        public List<PortfolioInstrument> Instruments { get; private set; }
    }
}

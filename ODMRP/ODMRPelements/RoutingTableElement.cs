using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    struct RoutingTableElement
    {
        public int SourceIp;
        public int NextHop;

        public RoutingTableElement(int s, int n)
        {
            SourceIp = s;
            NextHop = n;
        }
    }
}

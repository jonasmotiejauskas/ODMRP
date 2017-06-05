using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    public struct ForwardingTableElement
    {
        public int MulticastIp;

        public ForwardingTableElement(int mi)
        {
            MulticastIp = mi;
        }
    }
}

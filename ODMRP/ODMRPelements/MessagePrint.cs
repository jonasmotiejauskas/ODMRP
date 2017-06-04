using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    struct MessagePrint
    {
        public int Source;
        public int Sequence;

        public MessagePrint(int so, int sq)
        {
            Source = so;
            Sequence = sq;
        }
    }
}

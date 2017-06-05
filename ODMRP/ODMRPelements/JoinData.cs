using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    class JoinData : Packet
    {
        public int TTL;
        public int HopCount = 0;

        public JoinData( int ttl, int sN, int sI, int phI, int mgI)
        {
            PacketType = 1;
            SequenceNumber = sN;
            SourceIp = sI;
            PreviousHopIp = phI;
            MulticastGroupIp = mgI;
            TTL = ttl;
        }
    }
}

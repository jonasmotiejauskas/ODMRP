using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    public class Packet
    {
        public int PacketType;
        public int SequenceNumber;
        public int MulticastGroupIp;
        public int PreviousHopIp;
        public int SourceIp;
    }
}

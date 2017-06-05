using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    class JoinTable : Packet
    {
        public bool FG_Flag = false;
        public int NextHopIp;

        public JoinTable(int nhI, int sN, int sI, int phI, int mgI)
        {
            PacketType = 2;
            SequenceNumber = sN;
            SourceIp = sI;
            PreviousHopIp = phI;
            MulticastGroupIp = mgI;
            NextHopIp = nhI;
        }
    }
}

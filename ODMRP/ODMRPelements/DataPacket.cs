using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    class DataPacket
    {
        public int ReceiveIp;
        public int SourceIp;
        public string Message;
        public int SequenceId;

        public DataPacket(int sq, int rec, int src, string msg)
        {
            ReceiveIp = rec;
            SourceIp = src;
            Message = msg;
            SequenceId = sq;
        }
    }
}

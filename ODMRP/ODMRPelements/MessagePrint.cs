﻿using System;
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

        public MessagePrint(int sI, int sQ)
        {
            Source = sI;
            Sequence = sQ;
        }
    }
}

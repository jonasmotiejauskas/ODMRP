using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    class IncrementalNumberGenerator
    {
        static private int _number = 0;

        public int Number
        {
            get
            {
                _number++;
                return _number;
            }
            private set { }
        }
    }
}

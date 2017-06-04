using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMRP.ODMRPelements
{
    class Node
    {
        public static event EventHandler NodeUpdate;

        public int NodeId { get; private set; }
        private int _coordinateX;
        private int _coordinateY;
        private int _range;

        public virtual void OnThresholdReached(object sender, EventArgs e)
        {
            NodeUpdate?.Invoke(sender, e);
        }

        public Node()
        {
            NodeId = new IncrementalNumberGenerator().Number;
            Range = 80;
        }

        public int CoordinateX
        {
            get { return _coordinateX; }
            set
            {
                OnThresholdReached(this, new EventArgs());
                _coordinateX = value;
            }
        }

        public int CoordinateY
        {
            get { return _coordinateY; }
            set
            {
                OnThresholdReached(this, new EventArgs());
                _coordinateY = value;
            }
        }

        public int Range
        {
            get { return _range; }
            private set
            {
                OnThresholdReached(this, new EventArgs());
                _range = value;
            }
        }
    }
}

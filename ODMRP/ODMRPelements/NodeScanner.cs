using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace ODMRP.ODMRPelements
{
    class NodeScanner
    {
        public static Dictionary<double, Node> GetNearbyNodes(Node Sender, ControlCollection All)
        {
            List<Node> list = new List<Node>();
            Dictionary<double, Node> nearby = new Dictionary<double, Node>();

            foreach(var con in All)
            {
                if(con is UIelements.NodePanel)
                {
                    list.Add((con as UIelements.NodePanel).Node);
                }
            }

            foreach(var n in list)
            {
                double dist = Math.Sqrt((n.CoordinateX - Sender.CoordinateX) * (n.CoordinateX - Sender.CoordinateX) + (n.CoordinateY - Sender.CoordinateY) * (n.CoordinateY - Sender.CoordinateY));
                if (n != Sender && dist < Sender.Range)
                {
                    nearby.Add(dist, n);
                }
            }

            return nearby;
        }
    }
}

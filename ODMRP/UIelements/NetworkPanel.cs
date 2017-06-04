using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODMRP.UIelements
{
    class NetworkPanel : Panel
    {

        ControlCollection nodeCollection;

        public NetworkPanel(ControlCollection n)
        {
            nodeCollection = n;
            DoubleBuffered = false;
            ODMRPelements.Node.NodeUpdate += Node_NodeUpdate;
        }

        private void Node_NodeUpdate(object sender, EventArgs e)
        {
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            foreach(var nodeP in nodeCollection)
            {
                if (nodeP is UIelements.NodePanel)
                {
                    var node = (nodeP as UIelements.NodePanel).Node;
                    if((nodeP as UIelements.NodePanel).Selected)
                    {
                        e.Graphics.FillEllipse(Brushes.Red, new Rectangle(node.CoordinateX - 3, 500 - (node.CoordinateY + 3), 6, 6));
                        e.Graphics.DrawEllipse(new Pen(Brushes.Red), new Rectangle(node.CoordinateX - node.Range, 500 - (node.CoordinateY) - node.Range, node.Range * 2, node.Range * 2));
                        e.Graphics.DrawString(node.NodeId.ToString(), new Font("Arial", 11), new SolidBrush(Color.Red), node.CoordinateX, 500 - (node.CoordinateY + 20), new StringFormat());
                    }
                    else
                    {
                        e.Graphics.FillEllipse(Brushes.Black, new Rectangle(node.CoordinateX - 3, 500 - (node.CoordinateY + 3), 6, 6));
                        //e.Graphics.DrawEllipse(new Pen(Brushes.Black), new Rectangle(node.CoordinateX - node.Range, 500 - (node.CoordinateY) - node.Range, node.Range * 2, node.Range * 2));
                        e.Graphics.DrawString(node.NodeId.ToString(), new Font("Arial", 11), new SolidBrush(Color.Black), node.CoordinateX, 500 - (node.CoordinateY + 20), new StringFormat());
                    }    
                }
            }
        }
    }
}

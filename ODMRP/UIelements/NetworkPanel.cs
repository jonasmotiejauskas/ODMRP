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

        List<ODMRPelements.Node> nodeList = new List<ODMRPelements.Node>();

        public NetworkPanel(List<ODMRPelements.Node> n)
        {
            nodeList = n;
            DoubleBuffered = false;
            ODMRPelements.Node.NodeUpdate += Node_NodeUpdate;
        }

        private void Node_NodeUpdate(object sender, EventArgs e)
        {
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //10 is the grid size in pixel
            //Bitmap bmp = new Bitmap(10, 10);
            //Graphics bmpG = Graphics.FromImage(bmp);
            //bmpG.DrawEllipse(Pens.Black, 0, 0, 1, 1);
            //bmpG.DrawEllipse(Pens.Black, 0, 10, 1, 1);
            //bmpG.DrawEllipse(Pens.Black, 10, 10, 1, 1);
            //bmpG.DrawEllipse(Pens.Black, 10, 0, 1, 1);

            //TextureBrush b = new TextureBrush(bmp);

            //e.Graphics.FillRectangle(b, this.ClientRectangle);

            foreach(var node in nodeList)
            {
                e.Graphics.FillEllipse(Brushes.Black, new Rectangle(node.CoordinateX - 3, 500 - (node.CoordinateY + 3), 6, 6));
                e.Graphics.DrawEllipse(new Pen(Brushes.Black), new Rectangle(node.CoordinateX - node.Range, 500 - (node.CoordinateY) - node.Range, node.Range * 2, node.Range * 2));
                e.Graphics.DrawString(node.NodeId.ToString(), new Font("Arial", 11), new SolidBrush(Color.Black), node.CoordinateX, 500 - (node.CoordinateY + 20), new StringFormat());
            }

            //bmp.Dispose();
            //bmpG.Dispose();
            //b.Dispose();
        }
    }
}

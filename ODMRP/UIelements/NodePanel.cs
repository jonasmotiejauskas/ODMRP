using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODMRP.UIelements
{
    class NodePanel : Panel
    {

        public ODMRPelements.Node Node { get; private set; }
        public bool Selected { get; private set; }

        public NodePanel(ODMRPelements.Node n)
        {
            Node = n;
            Size = new Size(190, 40);
            Margin = new Padding(10, 5, 10, 0);
            Label label = new Label() { Size = this.Size, TextAlign = ContentAlignment.MiddleCenter, Text = "Node " + Node.NodeId };
            label.Enabled = false;
            Controls.Add(label);
            BackColor = Color.LightGray;
        }

        public void NodeSelect()
        {
            Selected = true;
            BackColor = Color.Red;
        }

        public void NodeUnselect()
        {
            Selected = false;
            BackColor = Color.LightGray;
        }
    }
}

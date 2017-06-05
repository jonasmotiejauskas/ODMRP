using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODMRP
{
    public partial class TableWindow : Form
    {
        public TableWindow(ODMRPelements.Node Node)
        {
            InitializeComponent();
            foreach(var a in Node.RoutingTable)
            {
                SourcePanel.Controls.Add(new Label() {Text = a.SourceIp.ToString() });
                NextHopPanel.Controls.Add(new Label() {Text = a.NextHop.ToString() });
            }
            foreach(var a in Node.ForwardingTable)
            {
                MulticastPanel.Controls.Add(new Label() {Text = a.MulticastIp.ToString() });
            }
        }
    }
}

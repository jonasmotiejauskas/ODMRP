using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ODMRP
{
    public partial class MainWindow : Form
    {
        List<ODMRPelements.Node> nodeList = new List<ODMRPelements.Node>();
        UIelements.NetworkPanel panel; 
        public MainWindow()
        {
            InitializeComponent();

            panel = new UIelements.NetworkPanel(nodeList)
            {
                BackColor = Color.LightGray,
                Size = new Size(703, 503),
                Location = new Point(30, 137),
                BorderStyle = BorderStyle.FixedSingle
            };

            Controls.Add(panel);
            
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            ODMRPelements.Node newNode = new ODMRPelements.Node() { CoordinateX = (int)CoordXInput.Value, CoordinateY = (int)CoordYInput.Value };
            nodeList.Add( newNode );
            newNode.OnThresholdReached( newNode, new EventArgs());
        }

        private void RemoveNode_Click(object sender, EventArgs e)
        {

        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {

        }
    }
}

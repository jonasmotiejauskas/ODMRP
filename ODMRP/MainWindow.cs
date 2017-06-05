using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ODMRP
{
    public partial class MainWindow : Form
    {
        UIelements.NetworkPanel panel;
        ODMRPelements.Node selectedNode;
         
        public MainWindow()
        {
            InitializeComponent();

            panel = new UIelements.NetworkPanel(NodeSelectPanel.Controls)
            {
                BackColor = Color.LightGray,
                Size = new Size(703, 503),
                Location = new Point(30, 137),
                BorderStyle = BorderStyle.FixedSingle
            };

            Controls.Add(panel);

            RemoveNode.Enabled = false;
            CoordXInput.Enabled = false;
            CoordXInput.ValueChanged += CoordXInput_ValueChanged;
            CoordXInput.Validated += CoordXInput_ValueChanged;
            CoordYInput.Enabled = false;
            CoordYInput.ValueChanged += CoordYInput_ValueChanged;
            CoordYInput.Validated += CoordYInput_ValueChanged;
        }

        private void CoordYInput_ValueChanged(object sender, EventArgs e)
        {
            if(selectedNode != null)
            {
                selectedNode.CoordinateX = (int)(sender as NumericUpDown).Value;
            }
        }

        private void CoordXInput_ValueChanged(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                selectedNode.CoordinateY = (int)(sender as NumericUpDown).Value;
            }
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            if(NodeSelectPanel.Controls.Count < 20)
            {
                ODMRPelements.Node newNode = new ODMRPelements.Node(NodeSelectPanel.Controls) { CoordinateX = 0, CoordinateY = 0 };

                UIelements.NodePanel newPanel = new UIelements.NodePanel(newNode);
                newPanel.Click += NewPanel_Click;
                NodeSelectPanel.Controls.Add(newPanel);
                NewPanel_Click(newPanel, new EventArgs());
                newNode.OnThresholdReached(newNode, new EventArgs());
            }

            if(NodeSelectPanel.Controls.Count > 0)
            {
                RemoveNode.Enabled = true;
            }
        }

        private void NewPanel_Click(object sender, EventArgs e)
        {
            

            foreach (var a in NodeSelectPanel.Controls)
            {
                if(a is UIelements.NodePanel)
                {
                    (a as UIelements.NodePanel).NodeUnselect();
                }
            }

            (sender as UIelements.NodePanel).NodeSelect();
            selectedNode = (sender as UIelements.NodePanel).Node;
            CoordXInput.Value = selectedNode.CoordinateY;
            CoordYInput.Value = selectedNode.CoordinateX;


            RemoveNode.Enabled = true;
            CoordXInput.Enabled = true;
            CoordYInput.Enabled = true;
        }

        private void RemoveNode_Click(object sender, EventArgs e)
        {
            foreach (var a in NodeSelectPanel.Controls)
            {
                if (a is UIelements.NodePanel)
                {
                    UIelements.NodePanel panel = (a as UIelements.NodePanel);
                    if (panel.Selected)
                    {
                        panel.NodeUnselect();
                        selectedNode = null;
                        NodeSelectPanel.Controls.Remove(panel);
                        panel.Node.OnThresholdReached(panel.Node, new EventArgs());
                        RemoveNode.Enabled = false;
                        CoordXInput.Enabled = false;
                        CoordYInput.Enabled = false;
                        CoordXInput.Value = 0;
                        CoordYInput.Value = 0;
                    }
                }
            }

            if (NodeSelectPanel.Controls.Count < 1)
            {
                RemoveNode.Enabled = false;
            }
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if(NodeFromIdInput.Value == NodeToIdInput.Value)
            {
                MessageBox.Show("Cannot Send data to the same node");
            }
            bool one = false;
            bool two = false;

            foreach(var a in NodeSelectPanel.Controls)
            {
                if(a is UIelements.NodePanel)
                {
                    if ((a as UIelements.NodePanel).Node.NodeId == NodeFromIdInput.Value)
                    {
                        one = true;
                    }
                    if ((a as UIelements.NodePanel).Node.NodeId == NodeToIdInput.Value)
                    {
                        two = true;
                    }
                }
            }

            if (!one)
            {
                MessageBox.Show("Node " + NodeFromIdInput.Value.ToString() + " doesnt exist");
            }
            else if (!two)
            {
                MessageBox.Show("Node " + NodeToIdInput.Value.ToString() + " doesnt exist");
            }
            else
            {
                foreach (var a in NodeSelectPanel.Controls)
                {
                    if (a is UIelements.NodePanel)
                    {
                        if ((a as UIelements.NodePanel).Node.NodeId == NodeFromIdInput.Value)
                        {
                            (a as UIelements.NodePanel).Node.SendMessage((int)NodeToIdInput.Value);
                        }
                    }
                }
            }
        }
    }
}

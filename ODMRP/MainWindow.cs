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
    public partial class MainWindow : Form
    {
        List<ODMRPelements.Node> nodeList = new List<ODMRPelements.Node>();
        UIelements.NetworkPanel panel = new UIelements.NetworkPanel() { BackColor = Color.LightGray, Size = new Size(700, 500), Location = new Point(30, 140), BorderStyle = BorderStyle.FixedSingle };

        public MainWindow()
        {
            InitializeComponent();
            Controls.Add(panel);
        }

    }
}

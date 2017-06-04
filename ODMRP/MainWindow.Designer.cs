namespace ODMRP
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NodeSelectPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NodeSelectLabel = new System.Windows.Forms.Label();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CoordYInput = new System.Windows.Forms.NumericUpDown();
            this.CoordXInput = new System.Windows.Forms.NumericUpDown();
            this.CoordYLabel = new System.Windows.Forms.Label();
            this.CoordXLabel = new System.Windows.Forms.Label();
            this.Option3Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NodeToIdInput = new System.Windows.Forms.NumericUpDown();
            this.NodeFromIdInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.SendNodeFromLabel = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.Option2Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Option1Name = new System.Windows.Forms.Label();
            this.RemoveNode = new System.Windows.Forms.Button();
            this.NodeSelectPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoordYInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordXInput)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodeToIdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NodeFromIdInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "700";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "350";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "250";
            // 
            // NodeSelectPanel
            // 
            this.NodeSelectPanel.AutoScroll = true;
            this.NodeSelectPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NodeSelectPanel.Controls.Add(this.NodeSelectLabel);
            this.NodeSelectPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NodeSelectPanel.Location = new System.Drawing.Point(747, 136);
            this.NodeSelectPanel.Name = "NodeSelectPanel";
            this.NodeSelectPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NodeSelectPanel.Size = new System.Drawing.Size(225, 513);
            this.NodeSelectPanel.TabIndex = 6;
            this.NodeSelectPanel.WrapContents = false;
            // 
            // NodeSelectLabel
            // 
            this.NodeSelectLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NodeSelectLabel.AutoSize = true;
            this.NodeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NodeSelectLabel.Location = new System.Drawing.Point(57, 8);
            this.NodeSelectLabel.Margin = new System.Windows.Forms.Padding(57, 8, 67, 0);
            this.NodeSelectLabel.Name = "NodeSelectLabel";
            this.NodeSelectLabel.Size = new System.Drawing.Size(101, 18);
            this.NodeSelectLabel.TabIndex = 12;
            this.NodeSelectLabel.Text = "Select a Node";
            this.NodeSelectLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddNodeButton
            // 
            this.AddNodeButton.Location = new System.Drawing.Point(13, 10);
            this.AddNodeButton.Name = "AddNodeButton";
            this.AddNodeButton.Size = new System.Drawing.Size(62, 58);
            this.AddNodeButton.TabIndex = 7;
            this.AddNodeButton.Text = "Add Node";
            this.AddNodeButton.UseVisualStyleBackColor = true;
            this.AddNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 112);
            this.panel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.CoordYInput);
            this.panel4.Controls.Add(this.CoordXInput);
            this.panel4.Controls.Add(this.CoordYLabel);
            this.panel4.Controls.Add(this.CoordXLabel);
            this.panel4.Controls.Add(this.Option3Label);
            this.panel4.Location = new System.Drawing.Point(482, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 91);
            this.panel4.TabIndex = 11;
            // 
            // CoordYInput
            // 
            this.CoordYInput.Location = new System.Drawing.Point(62, 14);
            this.CoordYInput.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.CoordYInput.Name = "CoordYInput";
            this.CoordYInput.Size = new System.Drawing.Size(92, 20);
            this.CoordYInput.TabIndex = 22;
            this.CoordYInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CoordXInput
            // 
            this.CoordXInput.Location = new System.Drawing.Point(62, 42);
            this.CoordXInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.CoordXInput.Name = "CoordXInput";
            this.CoordXInput.Size = new System.Drawing.Size(92, 20);
            this.CoordXInput.TabIndex = 21;
            this.CoordXInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CoordYLabel
            // 
            this.CoordYLabel.AutoSize = true;
            this.CoordYLabel.Location = new System.Drawing.Point(11, 49);
            this.CoordYLabel.Name = "CoordYLabel";
            this.CoordYLabel.Size = new System.Drawing.Size(45, 13);
            this.CoordYLabel.TabIndex = 18;
            this.CoordYLabel.Text = "Coord Y";
            // 
            // CoordXLabel
            // 
            this.CoordXLabel.AutoSize = true;
            this.CoordXLabel.Location = new System.Drawing.Point(11, 21);
            this.CoordXLabel.Name = "CoordXLabel";
            this.CoordXLabel.Size = new System.Drawing.Size(45, 13);
            this.CoordXLabel.TabIndex = 17;
            this.CoordXLabel.Text = "Coord X";
            // 
            // Option3Label
            // 
            this.Option3Label.AutoSize = true;
            this.Option3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Option3Label.Location = new System.Drawing.Point(38, 68);
            this.Option3Label.Name = "Option3Label";
            this.Option3Label.Size = new System.Drawing.Size(100, 18);
            this.Option3Label.TabIndex = 11;
            this.Option3Label.Text = "Node Options";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.NodeToIdInput);
            this.panel3.Controls.Add(this.NodeFromIdInput);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.SendNodeFromLabel);
            this.panel3.Controls.Add(this.SendMessageButton);
            this.panel3.Controls.Add(this.Option2Label);
            this.panel3.Location = new System.Drawing.Point(199, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 91);
            this.panel3.TabIndex = 10;
            // 
            // NodeToIdInput
            // 
            this.NodeToIdInput.Location = new System.Drawing.Point(79, 42);
            this.NodeToIdInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NodeToIdInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NodeToIdInput.Name = "NodeToIdInput";
            this.NodeToIdInput.Size = new System.Drawing.Size(92, 20);
            this.NodeToIdInput.TabIndex = 24;
            this.NodeToIdInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NodeToIdInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NodeFromIdInput
            // 
            this.NodeFromIdInput.InterceptArrowKeys = false;
            this.NodeFromIdInput.Location = new System.Drawing.Point(79, 14);
            this.NodeFromIdInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NodeFromIdInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NodeFromIdInput.Name = "NodeFromIdInput";
            this.NodeFromIdInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NodeFromIdInput.Size = new System.Drawing.Size(92, 20);
            this.NodeFromIdInput.TabIndex = 23;
            this.NodeFromIdInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NodeFromIdInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Receiver Id";
            // 
            // SendNodeFromLabel
            // 
            this.SendNodeFromLabel.AutoSize = true;
            this.SendNodeFromLabel.Location = new System.Drawing.Point(13, 21);
            this.SendNodeFromLabel.Name = "SendNodeFromLabel";
            this.SendNodeFromLabel.Size = new System.Drawing.Size(54, 13);
            this.SendNodeFromLabel.TabIndex = 12;
            this.SendNodeFromLabel.Text = "Source IP";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(185, 10);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(62, 58);
            this.SendMessageButton.TabIndex = 11;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Option2Label.Location = new System.Drawing.Point(86, 68);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(98, 18);
            this.Option2Label.TabIndex = 10;
            this.Option2Label.Text = "Send Options";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.Option1Name);
            this.panel2.Controls.Add(this.RemoveNode);
            this.panel2.Controls.Add(this.AddNodeButton);
            this.panel2.Location = new System.Drawing.Point(13, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 91);
            this.panel2.TabIndex = 9;
            // 
            // Option1Name
            // 
            this.Option1Name.AutoSize = true;
            this.Option1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Option1Name.Location = new System.Drawing.Point(34, 68);
            this.Option1Name.Name = "Option1Name";
            this.Option1Name.Size = new System.Drawing.Size(92, 18);
            this.Option1Name.TabIndex = 9;
            this.Option1Name.Text = "Grid Options";
            // 
            // RemoveNode
            // 
            this.RemoveNode.Location = new System.Drawing.Point(88, 10);
            this.RemoveNode.Name = "RemoveNode";
            this.RemoveNode.Size = new System.Drawing.Size(62, 58);
            this.RemoveNode.TabIndex = 8;
            this.RemoveNode.Text = "Remove Node";
            this.RemoveNode.UseVisualStyleBackColor = true;
            this.RemoveNode.Click += new System.EventHandler(this.RemoveNode_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NodeSelectPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODMRP simulation";
            this.NodeSelectPanel.ResumeLayout(false);
            this.NodeSelectPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoordYInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordXInput)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodeToIdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NodeFromIdInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel NodeSelectPanel;
        private System.Windows.Forms.Button AddNodeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveNode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Option1Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SendNodeFromLabel;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label Option2Label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Option3Label;
        private System.Windows.Forms.Label CoordYLabel;
        private System.Windows.Forms.Label CoordXLabel;
        private System.Windows.Forms.NumericUpDown CoordYInput;
        private System.Windows.Forms.NumericUpDown CoordXInput;
        private System.Windows.Forms.NumericUpDown NodeToIdInput;
        private System.Windows.Forms.NumericUpDown NodeFromIdInput;
        private System.Windows.Forms.Label NodeSelectLabel;
    }
}


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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Option1Name = new System.Windows.Forms.Label();
            this.RemoveNode = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Option2Label = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.SendNodeFromLabel = new System.Windows.Forms.Label();
            this.NodeFromIdInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NodeToIdInput = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Option3Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(747, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 513);
            this.flowLayoutPanel1.TabIndex = 6;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.NodeToIdInput);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.NodeFromIdInput);
            this.panel3.Controls.Add(this.SendNodeFromLabel);
            this.panel3.Controls.Add(this.SendMessageButton);
            this.panel3.Controls.Add(this.Option2Label);
            this.panel3.Location = new System.Drawing.Point(199, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 91);
            this.panel3.TabIndex = 10;
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Option2Label.Location = new System.Drawing.Point(106, 68);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(98, 18);
            this.Option2Label.TabIndex = 10;
            this.Option2Label.Text = "Send Options";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(235, 10);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(62, 58);
            this.SendMessageButton.TabIndex = 11;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // SendNodeFromLabel
            // 
            this.SendNodeFromLabel.AutoSize = true;
            this.SendNodeFromLabel.Location = new System.Drawing.Point(5, 21);
            this.SendNodeFromLabel.Name = "SendNodeFromLabel";
            this.SendNodeFromLabel.Size = new System.Drawing.Size(68, 13);
            this.SendNodeFromLabel.TabIndex = 12;
            this.SendNodeFromLabel.Text = "Node from Id";
            // 
            // NodeFromIdInput
            // 
            this.NodeFromIdInput.Location = new System.Drawing.Point(79, 14);
            this.NodeFromIdInput.Name = "NodeFromIdInput";
            this.NodeFromIdInput.Size = new System.Drawing.Size(138, 20);
            this.NodeFromIdInput.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Node to Id";
            // 
            // NodeToIdInput
            // 
            this.NodeToIdInput.Location = new System.Drawing.Point(79, 42);
            this.NodeToIdInput.Name = "NodeToIdInput";
            this.NodeToIdInput.Size = new System.Drawing.Size(138, 20);
            this.NodeToIdInput.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.Option3Label);
            this.panel4.Location = new System.Drawing.Point(564, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 91);
            this.panel4.TabIndex = 11;
            // 
            // Option3Label
            // 
            this.Option3Label.AutoSize = true;
            this.Option3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Option3Label.Location = new System.Drawing.Point(110, 68);
            this.Option3Label.Name = "Option3Label";
            this.Option3Label.Size = new System.Drawing.Size(100, 18);
            this.Option3Label.TabIndex = 11;
            this.Option3Label.Text = "Node Options";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddNodeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveNode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Option1Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NodeToIdInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NodeFromIdInput;
        private System.Windows.Forms.Label SendNodeFromLabel;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label Option2Label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Option3Label;
    }
}


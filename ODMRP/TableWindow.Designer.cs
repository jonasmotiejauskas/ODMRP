namespace ODMRP
{
    partial class TableWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableWindow));
            this.CoordYLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Option2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourcePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NextHopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MulticastPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SourcePanel.SuspendLayout();
            this.NextHopPanel.SuspendLayout();
            this.MulticastPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoordYLabel
            // 
            this.CoordYLabel.Location = new System.Drawing.Point(3, 5);
            this.CoordYLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.CoordYLabel.Name = "CoordYLabel";
            this.CoordYLabel.Size = new System.Drawing.Size(59, 13);
            this.CoordYLabel.TabIndex = 19;
            this.CoordYLabel.Text = "Source IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Multicast Group ID";
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Option2Label.Location = new System.Drawing.Point(70, 15);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(94, 18);
            this.Option2Label.TabIndex = 11;
            this.Option2Label.Text = "Routing table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(240, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Forward table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Next Hop IP";
            // 
            // SourcePanel
            // 
            this.SourcePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SourcePanel.Controls.Add(this.CoordYLabel);
            this.SourcePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SourcePanel.Location = new System.Drawing.Point(12, 45);
            this.SourcePanel.Name = "SourcePanel";
            this.SourcePanel.Size = new System.Drawing.Size(108, 308);
            this.SourcePanel.TabIndex = 22;
            // 
            // NextHopPanel
            // 
            this.NextHopPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NextHopPanel.Controls.Add(this.label2);
            this.NextHopPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NextHopPanel.Location = new System.Drawing.Point(119, 45);
            this.NextHopPanel.Name = "NextHopPanel";
            this.NextHopPanel.Size = new System.Drawing.Size(106, 308);
            this.NextHopPanel.TabIndex = 23;
            // 
            // MulticastPanel
            // 
            this.MulticastPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MulticastPanel.Controls.Add(this.label3);
            this.MulticastPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MulticastPanel.Location = new System.Drawing.Point(237, 45);
            this.MulticastPanel.Name = "MulticastPanel";
            this.MulticastPanel.Size = new System.Drawing.Size(101, 308);
            this.MulticastPanel.TabIndex = 23;
            // 
            // TableWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 365);
            this.Controls.Add(this.MulticastPanel);
            this.Controls.Add(this.NextHopPanel);
            this.Controls.Add(this.SourcePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Option2Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TableWindow";
            this.Text = "Router Info";
            this.SourcePanel.ResumeLayout(false);
            this.NextHopPanel.ResumeLayout(false);
            this.NextHopPanel.PerformLayout();
            this.MulticastPanel.ResumeLayout(false);
            this.MulticastPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Option2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CoordYLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel SourcePanel;
        private System.Windows.Forms.FlowLayoutPanel NextHopPanel;
        private System.Windows.Forms.FlowLayoutPanel MulticastPanel;
    }
}
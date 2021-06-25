namespace SimuladorUrnPolya
{
    partial class F_insertProbabilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_insertProbabilities));
            this.lb_memorylapse = new System.Windows.Forms.Label();
            this.tb_probability = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_memorylapse
            // 
            this.lb_memorylapse.AutoSize = true;
            this.lb_memorylapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_memorylapse.Location = new System.Drawing.Point(3, 9);
            this.lb_memorylapse.Name = "lb_memorylapse";
            this.lb_memorylapse.Size = new System.Drawing.Size(165, 16);
            this.lb_memorylapse.TabIndex = 0;
            this.lb_memorylapse.Text = "Memory Lapse Probability";
            this.lb_memorylapse.Click += new System.EventHandler(this.lb_memorylapse_Click);
            // 
            // tb_probability
            // 
            this.tb_probability.Location = new System.Drawing.Point(184, 8);
            this.tb_probability.Name = "tb_probability";
            this.tb_probability.Size = new System.Drawing.Size(114, 20);
            this.tb_probability.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 111);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(584, 0);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.tb_probability);
            this.panel.Controls.Add(this.lb_memorylapse);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(584, 31);
            this.panel.TabIndex = 3;
            // 
            // F_insertProbabilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 111);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 150);
            this.Name = "F_insertProbabilities";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.F_insertProbabilities_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_memorylapse;
        private System.Windows.Forms.TextBox tb_probability;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel;
    }
}
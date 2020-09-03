namespace SimuladorUrnPolya
{
    partial class Urn
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urn));
            this.Colors_listCheckBox = new System.Windows.Forms.CheckedListBox();
            this.btn_defineMatrix = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SimulationProgress = new System.Windows.Forms.ProgressBar();
            this.lb_steps = new System.Windows.Forms.Label();
            this.tb_Steps = new System.Windows.Forms.TextBox();
            this.btn_ResetColors = new System.Windows.Forms.Button();
            this.btn_startBallsNumbers = new System.Windows.Forms.Button();
            this.Btn_AddColor = new System.Windows.Forms.Button();
            this.tb_NewColor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Colors_listCheckBox
            // 
            this.Colors_listCheckBox.CheckOnClick = true;
            this.Colors_listCheckBox.FormattingEnabled = true;
            this.Colors_listCheckBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Black",
            "Yellow",
            "Pink",
            "Purple",
            "Orange",
            "Brown"});
            this.Colors_listCheckBox.Location = new System.Drawing.Point(0, 19);
            this.Colors_listCheckBox.Name = "Colors_listCheckBox";
            this.Colors_listCheckBox.Size = new System.Drawing.Size(110, 139);
            this.Colors_listCheckBox.TabIndex = 0;
            this.Colors_listCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Colors_listCheckBox_ItemCheck);
            this.Colors_listCheckBox.SelectedIndexChanged += new System.EventHandler(this.Colors_listCheckBox_SelectedIndexChanged);
            // 
            // btn_defineMatrix
            // 
            this.btn_defineMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_defineMatrix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_defineMatrix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_defineMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_defineMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defineMatrix.Location = new System.Drawing.Point(2, 252);
            this.btn_defineMatrix.Name = "btn_defineMatrix";
            this.btn_defineMatrix.Size = new System.Drawing.Size(249, 29);
            this.btn_defineMatrix.TabIndex = 7;
            this.btn_defineMatrix.Text = "Define Matrix";
            this.btn_defineMatrix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_defineMatrix.UseVisualStyleBackColor = false;
            this.btn_defineMatrix.Click += new System.EventHandler(this.btn_defineMatrix_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(2, 287);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(249, 27);
            this.btn_Confirm.TabIndex = 8;
            this.btn_Confirm.Text = "Simulate";
            this.btn_Confirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // SimulationProgress
            // 
            this.SimulationProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SimulationProgress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SimulationProgress.Location = new System.Drawing.Point(2, 320);
            this.SimulationProgress.Name = "SimulationProgress";
            this.SimulationProgress.Size = new System.Drawing.Size(249, 27);
            this.SimulationProgress.TabIndex = 9;
            // 
            // lb_steps
            // 
            this.lb_steps.AutoSize = true;
            this.lb_steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_steps.Location = new System.Drawing.Point(3, 216);
            this.lb_steps.Name = "lb_steps";
            this.lb_steps.Size = new System.Drawing.Size(43, 16);
            this.lb_steps.TabIndex = 10;
            this.lb_steps.Text = "Steps";
            this.lb_steps.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_steps.Click += new System.EventHandler(this.lb_steps_Click);
            // 
            // tb_Steps
            // 
            this.tb_Steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Steps.Location = new System.Drawing.Point(52, 216);
            this.tb_Steps.Name = "tb_Steps";
            this.tb_Steps.Size = new System.Drawing.Size(60, 26);
            this.tb_Steps.TabIndex = 11;
            this.tb_Steps.Text = "0";
            this.tb_Steps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Steps.TextChanged += new System.EventHandler(this.tb_Steps_TextChanged);
            // 
            // btn_ResetColors
            // 
            this.btn_ResetColors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ResetColors.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ResetColors.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ResetColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetColors.Location = new System.Drawing.Point(114, 131);
            this.btn_ResetColors.Name = "btn_ResetColors";
            this.btn_ResetColors.Size = new System.Drawing.Size(131, 27);
            this.btn_ResetColors.TabIndex = 3;
            this.btn_ResetColors.Text = "Reset Colors";
            this.btn_ResetColors.UseVisualStyleBackColor = false;
            this.btn_ResetColors.Click += new System.EventHandler(this.btn_ResetColors_Click);
            // 
            // btn_startBallsNumbers
            // 
            this.btn_startBallsNumbers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_startBallsNumbers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_startBallsNumbers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_startBallsNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startBallsNumbers.Location = new System.Drawing.Point(114, 98);
            this.btn_startBallsNumbers.Name = "btn_startBallsNumbers";
            this.btn_startBallsNumbers.Size = new System.Drawing.Size(131, 27);
            this.btn_startBallsNumbers.TabIndex = 6;
            this.btn_startBallsNumbers.Text = "Balls Number";
            this.btn_startBallsNumbers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_startBallsNumbers.UseVisualStyleBackColor = false;
            this.btn_startBallsNumbers.Click += new System.EventHandler(this.btn_startBallsNumbers_Click);
            // 
            // Btn_AddColor
            // 
            this.Btn_AddColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_AddColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_AddColor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_AddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddColor.Location = new System.Drawing.Point(114, 45);
            this.Btn_AddColor.Name = "Btn_AddColor";
            this.Btn_AddColor.Size = new System.Drawing.Size(131, 27);
            this.Btn_AddColor.TabIndex = 1;
            this.Btn_AddColor.Text = "Add new color";
            this.Btn_AddColor.UseVisualStyleBackColor = false;
            this.Btn_AddColor.Click += new System.EventHandler(this.Btn_AddColor_Click);
            // 
            // tb_NewColor
            // 
            this.tb_NewColor.Location = new System.Drawing.Point(114, 19);
            this.tb_NewColor.Name = "tb_NewColor";
            this.tb_NewColor.Size = new System.Drawing.Size(127, 20);
            this.tb_NewColor.TabIndex = 5;
            this.tb_NewColor.Text = "new color";
            this.tb_NewColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_NewColor.TextChanged += new System.EventHandler(this.tb_NewColor_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_NewColor);
            this.groupBox1.Controls.Add(this.Btn_AddColor);
            this.groupBox1.Controls.Add(this.btn_startBallsNumbers);
            this.groupBox1.Controls.Add(this.btn_ResetColors);
            this.groupBox1.Controls.Add(this.Colors_listCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balls";
            // 
            // Urn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(254, 361);
            this.Controls.Add(this.lb_steps);
            this.Controls.Add(this.tb_Steps);
            this.Controls.Add(this.SimulationProgress);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_defineMatrix);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 400);
            this.Name = "Urn";
            this.Text = "Simulador Urn Polya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Colors_listCheckBox;
        private System.Windows.Forms.Button btn_defineMatrix;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.ProgressBar SimulationProgress;
        private System.Windows.Forms.Label lb_steps;
        private System.Windows.Forms.TextBox tb_Steps;
        private System.Windows.Forms.Button btn_ResetColors;
        private System.Windows.Forms.Button btn_startBallsNumbers;
        private System.Windows.Forms.Button Btn_AddColor;
        private System.Windows.Forms.TextBox tb_NewColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


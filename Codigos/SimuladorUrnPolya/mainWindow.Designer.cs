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
            this.btn_defineRepositionMatrix = new System.Windows.Forms.Button();
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
            this.op_graficos = new System.Windows.Forms.ComboBox();
            this.lb_simulations = new System.Windows.Forms.Label();
            this.tb_simulations = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lb_grafico = new System.Windows.Forms.Label();
            this.lb_simulationProcess = new System.Windows.Forms.Label();
            this.cb_simulationProcess = new System.Windows.Forms.ComboBox();
            this.btn_insertProbabilities = new System.Windows.Forms.Button();
            this.btn_defineProbabilitiesMatrix = new System.Windows.Forms.Button();
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
            // btn_defineRepositionMatrix
            // 
            this.btn_defineRepositionMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_defineRepositionMatrix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_defineRepositionMatrix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_defineRepositionMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_defineRepositionMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defineRepositionMatrix.Location = new System.Drawing.Point(2, 325);
            this.btn_defineRepositionMatrix.Name = "btn_defineRepositionMatrix";
            this.btn_defineRepositionMatrix.Size = new System.Drawing.Size(254, 29);
            this.btn_defineRepositionMatrix.TabIndex = 7;
            this.btn_defineRepositionMatrix.Text = "Define Reposition Matrix";
            this.btn_defineRepositionMatrix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_defineRepositionMatrix.UseVisualStyleBackColor = false;
            this.btn_defineRepositionMatrix.Click += new System.EventHandler(this.btn_defineMatrix_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(2, 394);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(254, 27);
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
            this.SimulationProgress.Location = new System.Drawing.Point(2, 436);
            this.SimulationProgress.Name = "SimulationProgress";
            this.SimulationProgress.Size = new System.Drawing.Size(254, 27);
            this.SimulationProgress.TabIndex = 9;
            // 
            // lb_steps
            // 
            this.lb_steps.AutoSize = true;
            this.lb_steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_steps.Location = new System.Drawing.Point(-1, 280);
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
            this.tb_Steps.Location = new System.Drawing.Point(48, 280);
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
            this.groupBox1.Location = new System.Drawing.Point(2, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balls";
            // 
            // op_graficos
            // 
            this.op_graficos.FormattingEnabled = true;
            this.op_graficos.Items.AddRange(new object[] {
            "Colors Run",
            "Ration Colors"});
            this.op_graficos.Location = new System.Drawing.Point(128, 5);
            this.op_graficos.Name = "op_graficos";
            this.op_graficos.Size = new System.Drawing.Size(121, 21);
            this.op_graficos.TabIndex = 13;
            this.op_graficos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_simulations
            // 
            this.lb_simulations.AutoSize = true;
            this.lb_simulations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_simulations.Location = new System.Drawing.Point(113, 280);
            this.lb_simulations.Name = "lb_simulations";
            this.lb_simulations.Size = new System.Drawing.Size(77, 16);
            this.lb_simulations.TabIndex = 14;
            this.lb_simulations.Text = "Simulations";
            this.lb_simulations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_simulations
            // 
            this.tb_simulations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_simulations.Location = new System.Drawing.Point(196, 280);
            this.tb_simulations.Name = "tb_simulations";
            this.tb_simulations.Size = new System.Drawing.Size(60, 26);
            this.tb_simulations.TabIndex = 15;
            this.tb_simulations.Text = "0";
            this.tb_simulations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // lb_grafico
            // 
            this.lb_grafico.AutoSize = true;
            this.lb_grafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_grafico.Location = new System.Drawing.Point(-1, 6);
            this.lb_grafico.Name = "lb_grafico";
            this.lb_grafico.Size = new System.Drawing.Size(74, 16);
            this.lb_grafico.TabIndex = 16;
            this.lb_grafico.Text = "Chart Type";
            // 
            // lb_simulationProcess
            // 
            this.lb_simulationProcess.AutoSize = true;
            this.lb_simulationProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_simulationProcess.Location = new System.Drawing.Point(-1, 42);
            this.lb_simulationProcess.Name = "lb_simulationProcess";
            this.lb_simulationProcess.Size = new System.Drawing.Size(123, 16);
            this.lb_simulationProcess.TabIndex = 17;
            this.lb_simulationProcess.Text = "Simulation Process";
            // 
            // cb_simulationProcess
            // 
            this.cb_simulationProcess.FormattingEnabled = true;
            this.cb_simulationProcess.Items.AddRange(new object[] {
            "Standard",
            "Memory Lapse",
            "Random Urn"});
            this.cb_simulationProcess.Location = new System.Drawing.Point(128, 42);
            this.cb_simulationProcess.Name = "cb_simulationProcess";
            this.cb_simulationProcess.Size = new System.Drawing.Size(121, 21);
            this.cb_simulationProcess.TabIndex = 18;
            this.cb_simulationProcess.SelectedIndexChanged += new System.EventHandler(this.cb_simulationProcess_SelectedIndexChanged);
            // 
            // btn_insertProbabilities
            // 
            this.btn_insertProbabilities.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_insertProbabilities.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_insertProbabilities.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_insertProbabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertProbabilities.Location = new System.Drawing.Point(29, 76);
            this.btn_insertProbabilities.Name = "btn_insertProbabilities";
            this.btn_insertProbabilities.Size = new System.Drawing.Size(214, 27);
            this.btn_insertProbabilities.TabIndex = 19;
            this.btn_insertProbabilities.Text = "Insert Lapse Probabilities";
            this.btn_insertProbabilities.UseVisualStyleBackColor = false;
            this.btn_insertProbabilities.Click += new System.EventHandler(this.btn_insertProbabilities_Click);
            // 
            // btn_defineProbabilitiesMatrix
            // 
            this.btn_defineProbabilitiesMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_defineProbabilitiesMatrix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_defineProbabilitiesMatrix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_defineProbabilitiesMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_defineProbabilitiesMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defineProbabilitiesMatrix.Location = new System.Drawing.Point(2, 360);
            this.btn_defineProbabilitiesMatrix.Name = "btn_defineProbabilitiesMatrix";
            this.btn_defineProbabilitiesMatrix.Size = new System.Drawing.Size(254, 29);
            this.btn_defineProbabilitiesMatrix.TabIndex = 20;
            this.btn_defineProbabilitiesMatrix.Text = "Define Probability Matrix";
            this.btn_defineProbabilitiesMatrix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_defineProbabilitiesMatrix.UseVisualStyleBackColor = false;
            this.btn_defineProbabilitiesMatrix.Click += new System.EventHandler(this.btn_defineProbabilityMatrix_Click);
            // 
            // Urn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(259, 475);
            this.Controls.Add(this.btn_defineProbabilitiesMatrix);
            this.Controls.Add(this.btn_insertProbabilities);
            this.Controls.Add(this.cb_simulationProcess);
            this.Controls.Add(this.lb_simulationProcess);
            this.Controls.Add(this.lb_grafico);
            this.Controls.Add(this.tb_simulations);
            this.Controls.Add(this.lb_simulations);
            this.Controls.Add(this.op_graficos);
            this.Controls.Add(this.lb_steps);
            this.Controls.Add(this.tb_Steps);
            this.Controls.Add(this.SimulationProgress);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_defineRepositionMatrix);
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
        private System.Windows.Forms.Button btn_defineRepositionMatrix;
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
        private System.Windows.Forms.ComboBox op_graficos;
        private System.Windows.Forms.Label lb_simulations;
        private System.Windows.Forms.TextBox tb_simulations;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lb_grafico;
        private System.Windows.Forms.Label lb_simulationProcess;
        private System.Windows.Forms.ComboBox cb_simulationProcess;
        private System.Windows.Forms.Button btn_insertProbabilities;
        private System.Windows.Forms.Button btn_defineProbabilitiesMatrix;
    }
}


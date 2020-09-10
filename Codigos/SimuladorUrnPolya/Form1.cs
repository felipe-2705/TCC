using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UrnPolya;


namespace SimuladorUrnPolya
{
    
    public partial class Urn : Form
    {
        public int ColorsTotalNumber;
        public List<string> ColorsUsedList = new List<string>();
        public int[] Colorsnumbers;
        public int[,] repositionMatrix;
        private string selectChartType ;
        private int steps;
        private int simulations;
        public Urn()
        {
            InitializeComponent();
            Colors_listCheckBox.SetItemChecked(0, true);
            Colors_listCheckBox.SetItemChecked(1, true);
            foreach (string s in Colors_listCheckBox.CheckedItems)
            {

                if (!this.ColorsUsedList.Contains(s))
                {
                    this.ColorsUsedList.Add(s);
                }
            }
            ColorsTotalNumber = 2;
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Colors Fuctions

        private void lb_BallsColors_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AddColor_Click(object sender, EventArgs e)
        {   string color = tb_NewColor.Text;
            if(color == "" || color=="new color")
            {
                MessageBox.Show("Please, insert a color value","Error");
                return;
            }
            Colors_listCheckBox.Items.Add(color, true);
            tb_NewColor.Text = "";
            tb_NewColor.Focus();
        }

        private void btn_ResetColors_Click(object sender, EventArgs e)
        {
            Colors_listCheckBox.Items.Clear();
            Colors_listCheckBox.Items.Add("Blue");
            Colors_listCheckBox.Items.Add("Red");
            Colors_listCheckBox.Items.Add("Green");
            Colors_listCheckBox.Items.Add("Black");
            Colors_listCheckBox.Items.Add("Yellow");
            Colors_listCheckBox.Items.Add("Pink");
            Colors_listCheckBox.Items.Add("Purple");
            Colors_listCheckBox.Items.Add("Orange");
            Colors_listCheckBox.Items.Add("Brown");
            Colors_listCheckBox.SetItemChecked(0, true);
            Colors_listCheckBox.SetItemChecked(1, true);
            this.ColorsUsedList.Clear();
            foreach (string s in Colors_listCheckBox.CheckedItems)
            {

               
             
                    this.ColorsUsedList.Add(s);
                
            }
            ColorsTotalNumber = 2;

        }

        private void tb_NewColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Colors_listCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ColorsUsedList.Clear();
            foreach (string s in Colors_listCheckBox.CheckedItems)
            {

                if (!this.ColorsUsedList.Contains(s))
                {
                    this.ColorsUsedList.Add(s);
                }
            }
            this.ColorsTotalNumber = this.ColorsUsedList.Count;
        }

        #endregion

        #region Simulation Params
        private void btn_startBallsNumbers_Click(object sender, EventArgs e)
        {
            
            this.Colorsnumbers = new int[this.ColorsUsedList.Count];
            F_InsertBallsNumbers F_insert = new F_InsertBallsNumbers(this.ColorsUsedList, ref this.Colorsnumbers);
            F_insert.ShowDialog();
            
        }

       

        private void btn_defineMatrix_Click(object sender, EventArgs e)
        {   
            if(this.repositionMatrix == null)
            {
                this.repositionMatrix = new int[this.ColorsTotalNumber, this.ColorsTotalNumber];
            }
            F_matrix f_matrix = new F_matrix(this.ColorsUsedList, ref this.repositionMatrix);
            f_matrix.ShowDialog();

        }
        #endregion
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (this.ColorsTotalNumber < 2 || this.repositionMatrix == null || this.Colorsnumbers == null)
            {
                MessageBox.Show("Please, insert all necessary information before continue if your simulation");
            }

        

            switch (this.selectChartType) 
            {
                case "Corrida de cores":
                    this.backgroundWorker2.RunWorkerAsync();
                    break;
                case "Probabilidade de razoes para cada cor":
                    this.backgroundWorker.RunWorkerAsync();
                    break;
            }
        }

      

        

     

        private void lb_steps_Click(object sender, EventArgs e)
        {

        }

       
        private void tb_Steps_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Colors_listCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                this.ColorsUsedList.Add(Colors_listCheckBox.Items[e.Index].ToString());

            }
            this.ColorsTotalNumber = this.ColorsUsedList.Count;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectChartType = op_graficos.Text;
        }
        #region Probability Chart Worker functions
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.PrintChart(this.backgroundWorker);
        }

        
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.SimulationProgress.Value = e.ProgressPercentage;
            this.SimulationProgress.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        public void PrintChart(BackgroundWorker b)
        {

            if (!int.TryParse(this.tb_Steps.Text, out this.steps))
            {
                MessageBox.Show("Please insert a valid value to the steps box");
                b.CancelAsync();
                return;
            }

            if (!int.TryParse(this.tb_simulations.Text, out this.simulations))
            {
                MessageBox.Show("Please insert a valid value to the simulations box");
                b.CancelAsync();
                return;
            }
            UrnPolya.Urn a = new UrnPolya.Urn(this.repositionMatrix, this.Colorsnumbers);
            List<double[]> r = UrnPolya.Urn.probability_of_colors_ration(a, steps, simulations, b);


            F_grafico f = new F_grafico(r, this.ColorsUsedList);
            f.ShowDialog();
        }
        #endregion

        #region ColorRunWorker functions
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            this.printColorRunChart(this.backgroundWorker2);
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.SimulationProgress.Value = e.ProgressPercentage;
            this.SimulationProgress.Update();

        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        public void printColorRunChart(BackgroundWorker b)
        {
            if (!int.TryParse(this.tb_Steps.Text, out this.steps))
            {
                MessageBox.Show("Please insert a valid value to the steps box");
                b.CancelAsync();
                return;
            }

            UrnPolya.Urn u = new UrnPolya.Urn(this.repositionMatrix, this.Colorsnumbers);
            u.simulation(steps, this.backgroundWorker2);
            double[,] result = u.getProportions();

            F_grafico f_grafico = new F_grafico(result, this.ColorsUsedList, steps + 1);
            f_grafico.ShowDialog();
        }
        #endregion
    }
}

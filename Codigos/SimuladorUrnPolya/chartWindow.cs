using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimuladorUrnPolya
{
    public partial class F_grafico : Form
    {
        double[,] data;
        List<string> Colors;
        int matrixSize;

        public F_grafico(double[,] data, List<string> colors, int matrixSize)
        {
            this.Colors = colors;
            this.matrixSize = matrixSize;
            this.data = data;
            InitializeComponent();
            this.Linechart();
        }

        public F_grafico(double[,] data, List<string> colors)
        {
            this.data = data;
            this.Colors = colors;
            InitializeComponent();
            this.LineChartAvarageRatio();
        }

        private void Linechart()
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();


            Grafico.Titles.Add("Colors Run");
            Grafico.Titles[0].Font = new Font("Arial", 14);
            Grafico.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Grafico.ChartAreas[0].AxisX.Title = "Step";
            Grafico.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            Grafico.ChartAreas[0].AxisY.Title = "proportion";
            for (int j = 0; j < this.Colors.Count; j++)
            {   x.Clear();
                y.Clear(); 
                for(int i =0;i<this.matrixSize; i++)
                {
                    y.Add(data[i,j]);
                    x.Add(i);
                }
                string color = this.Colors[j];
                Grafico.Series.Add(color);
                Grafico.Series[color].ChartType = SeriesChartType.Line;
                Grafico.Series[color].Color = Color.FromName(color);
                Grafico.Series[color].Points.DataBindXY(x,y);
                Grafico.Series[color].LegendText = "proportion color " + j.ToString();
             
            }
            

        }

        private void LineChartAvarageRatio()
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            Grafico.Titles.Add("Final proportion per execution");
            Grafico.Titles[0].Font = new Font("Arial", 14);
            Grafico.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Grafico.ChartAreas[0].AxisX.Title = "Execution";
            Grafico.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            Grafico.ChartAreas[0].AxisY.Title = "proportion";

            for (int j = 0; j < this.Colors.Count; j++)
            {
                x.Clear();
                y.Clear();
                for (int i = 0; i < this.data.GetLength(0); i++)
                {
                    
                        x.Add(i);
                        y.Add(this.data[i,j]);

                    
                }
                string color = this.Colors[j];
                Grafico.Series.Add(color);
                Grafico.Series[color].ChartType = SeriesChartType.Line;
                Grafico.Series[color].Color = Color.FromName(color);
                Grafico.Series[color].Points.DataBindXY(x, y);
                Grafico.Series[color].LegendText = "proportion color " + j.ToString();
            }


        }
        private void Grafico_Click(object sender, EventArgs e)
        {

        }
    }
}

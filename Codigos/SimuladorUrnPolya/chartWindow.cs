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

        List<double[]> probabilities;
        public F_grafico(double[,] data, List<string> colors, int matrixSize)
        {
            this.Colors = colors;
            this.matrixSize = matrixSize;
            this.data = data;
            InitializeComponent();
            this.Linechart();
        }

        public F_grafico(List<double[]> data, List<string> colors)
        {
            this.probabilities = data;
            this.Colors = colors;
            InitializeComponent();
            this.LinechartProbabilities();
        }

        private void Linechart()
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            Grafico.Titles.Add("Colors Run");
            Grafico.Titles[0].Font = new Font("Arial", 14);
            Grafico.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Grafico.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            for(int j = 0; j < this.Colors.Count; j++)
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
             
            }
            

        }

        private void LinechartProbabilities()
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            Grafico.Titles.Add("Probabilities ");
            Grafico.Titles[0].Font = new Font("Arial", 14);
            Grafico.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Grafico.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            int valor_pos = this.Colors.Count;

            for (int j = 0; j < this.Colors.Count; j++)
            {
                x.Clear();
                y.Clear();
                for (int i = 0; i < this.probabilities.Count; i++)
                {
                    
                        x.Add(Math.Round(this.probabilities[i][valor_pos],4));
                        y.Add(this.probabilities[i][j]);

                    
                }
                string color = this.Colors[j];
                Grafico.Series.Add(color);
                Grafico.Series[color].ChartType = SeriesChartType.Line;
                Grafico.Series[color].Color = Color.FromName(color);
                Grafico.Series[color].Points.DataBindXY(x, y);

            }


        }
        private void Grafico_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace SimuladorUrnPolya
{
    public partial class F_insertProbabilities : Form
    {
        List<string> colors;
        double[] probabilities;
        List<TextBox> tb_colors;
        double memorylapses;
        public F_insertProbabilities(List<string> colors, ref double memoryLapses_probability,ref double[] probabilities)
        {
            this.colors = colors;
            this.probabilities = probabilities;
            this.memorylapses = memoryLapses_probability;
            InitializeComponent();
            this.insert_components();
        }

        private void F_insertProbabilities_Load(object sender, EventArgs e)
        {

        }

        private void insert_components()
        {
            tb_colors = new List<TextBox>();
            foreach (string color in colors)
            {   //creating a label to color name
                Label lb = new Label();
                lb.Text = color;
                lb.Size = new Size(50, 20);
                //textBox to insert the desired inital value to that color 
                TextBox tb = new TextBox();
                tb.Text = Math.Round((1.0/this.colors.Count),2).ToString();
                tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                tb.Size = new Size(100, 20);
                tb_colors.Add(tb);
                this.flowLayoutPanel.Controls.Add(lb);
                this.flowLayoutPanel.Controls.Add(tb);
            }
            // creating cancel and confirm buttons 

            Button btn_confirm = new Button();
            btn_confirm.Text = "Confirm";
            btn_confirm.Size = new Size(100, 20);
            btn_confirm.Click += new System.EventHandler(btn_confirm_click_event);
            this.flowLayoutPanel.Controls.Add(btn_confirm);

            Button btn_cancel = new Button();
            btn_cancel.Text = "Cancel";
            btn_cancel.Size = new Size(100, 20);
            btn_cancel.Click += new System.EventHandler(btn_cancel_click_event);
            this.flowLayoutPanel.Controls.Add(btn_cancel);
        }

        private void btn_confirm_click_event(object sender, EventArgs e)
        {
            double values_sum = 0.0;
            double[] values = new double[this.colors.Count];
            int i = 0;
            double value;

            foreach(TextBox tb in this.tb_colors)
            {

                if (!double.TryParse(tb.Text, out value))
                {
                    MessageBox.Show("Insert a valid value ");
                    return;
                }
                values_sum += Math.Round(value, 2);
                values[i++] = Math.Round(value, 2);
            }

            if(values_sum>1.0 || values_sum < 0.999)
            {
                MessageBox.Show("Values sum must to be 1.0");
                return;
            }

            if(!double.TryParse(tb_probability.Text,out value))
            {
                MessageBox.Show("Insert a valid value ");
                return;
            }

            this.memorylapses = value;
            i = 0;
            foreach(double d in values)
            {
                this.probabilities[i++] = d;
            }

            MessageBox.Show("Values were sucessfully inserted ");
            this.Close();
            return;
        }



        private void btn_cancel_click_event(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_memorylapse_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorUrnPolya
{
    public partial class F_InsertBallsNumbers : Form
    {
        private int[] colorsNumbers;
        List<string> colors;
        List<TextBox> tb_colors;
        public F_InsertBallsNumbers(List<string>colors,ref int[] colorsNumbers)
        {
            this.colorsNumbers = colorsNumbers; // this represente the inital number to each color in the simulation
            this.colors = colors;   // the list of colors names
            InitializeComponent();
            this.addComponents();
           
            
            
        }

        private void addComponents()
        {
            tb_colors = new List<TextBox>();
            int i = 0;
            foreach(string color in colors)
            {   //creating a label to color name
                Label lb = new Label();
                lb.Text = color;
                lb.Size = new Size(50, 20);
                //textBox to insert the desired inital value to that color 
                TextBox tb = new TextBox();
                tb.Text = this.colorsNumbers[i++].ToString();
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
        {   int i = 0;
            int number;
            foreach(TextBox tb in this.tb_colors)
            {
                if (int.TryParse(tb.Text, out number))
                {   
                    if(number < 0)
                    {
                        MessageBox.Show("Please, insert a positive value");
                    }
                    this.colorsNumbers[i++] = number;
                }
                else
                {
                    MessageBox.Show("please insert a integer number!", "Error: Invalid enter value");
                    return;
                }
            }

            MessageBox.Show("Initial Colors values successfully inserted", "Message");
            this.Close();
        }

        private void btn_cancel_click_event(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}

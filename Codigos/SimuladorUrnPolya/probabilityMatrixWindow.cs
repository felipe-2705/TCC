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
    public partial class F_probabilityMatrixWindow : Form
    {
        private double[,] matrix;
        private int size;
        private List<string> colors;
        private TextBox[,] tb_handler;
        public F_probabilityMatrixWindow(List<string> colors, ref double[,] m)
        {
            this.size = colors.Count;
            this.tb_handler = new TextBox[size, size];
            this.matrix = m;
            this.colors = colors;
            InitializeComponent();
            this.createMatrix();
        }

        private void createMatrix()
        {
            int i = 0;
            int j = 0;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
             | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = this.size + 1;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = this.size + 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            for (i = 0; i < this.size + 1; i++)
            {

                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80));
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80));

            }

            for (j = 1; j < this.size + 1; j++)
            {
                Label lb = new Label();
                lb.Text = this.colors[j - 1];
                lb.Size = new Size(50, 50);
                //lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                Label lb1 = new Label();
                lb1.Text = this.colors[j - 1];
                lb1.Size = new Size(50, 50);
                // lb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                tableLayoutPanel1.Controls.Add(lb, 0, j);
                tableLayoutPanel1.Controls.Add(lb1, j, 0);
            }

            for (i = 1; i < this.size + 1; i++)
            {
                for (j = 1; j < this.size + 1; j++)
                {
                    TextBox tb = new TextBox();
                    tb.Text = this.matrix[i - 1, j - 1].ToString(System.Globalization.CultureInfo.InvariantCulture);
                    tb.Size = new Size(50, 50);
                    tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    tableLayoutPanel1.Controls.Add(tb, i, j);
                    this.tb_handler[i - 1, j - 1] = tb;

                }

            }

            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.Controls.Add(this.tableLayoutPanel1);

        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            double number;
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    if (double.TryParse(this.tb_handler[i, j].Text,System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out number))
                    {
                        this.matrix[i, j] = number;

                    }
                    else
                    {
                        MessageBox.Show("Please, insert a valid value", "Error: Value is not double type");
                        return;
                    }
                }
            }

            MessageBox.Show("Values sucessfully inserted in system");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    
    public partial class Urn : Form
    {
        public int ColorsTotalNumber;
        public List<string> ColorsUsedList = new List<string>();
        public int[] Colorsnumbers;
        public int[,] repositionMatrix;

        public Urn()
        {
            InitializeComponent();
            Colors_listCheckBox.SetItemChecked(0, true);
            Colors_listCheckBox.SetItemChecked(1, true);
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

        }

        private void tb_NewColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Colors_listCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            F_matrix f_matrix = new F_matrix(this.ColorsUsedList, out this.repositionMatrix);
            f_matrix.ShowDialog();

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

         
            ColorsTotalNumber = this.ColorsUsedList.Count;
            string txt = ColorsTotalNumber.ToString()+"\n";
            int i = 0;
            foreach(string s in this.ColorsUsedList)
            {   
          
                txt += this.Colorsnumbers[i++].ToString()+": "+ s+"\n";
            }

            for(i = 0; i < this.ColorsTotalNumber; i++)
            {
                for(int j = 0; j < this.ColorsTotalNumber; j++)
                {
                    txt += this.repositionMatrix[i, j].ToString()+" ";
                }
                txt += "\n";
            }

            MessageBox.Show(txt);
        }

        private void lb_steps_Click(object sender, EventArgs e)
        {

        }

       
        private void tb_Steps_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void Colors_listCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            foreach (string s in Colors_listCheckBox.CheckedItems)
            {

                if (!this.ColorsUsedList.Contains(s))
                {
                    this.ColorsUsedList.Add(s);
                }
            }

            if(e.NewValue == CheckState.Checked)
            {
                this.ColorsUsedList.Add(Colors_listCheckBox.Items[e.Index].ToString());

            }

        }
    }
}

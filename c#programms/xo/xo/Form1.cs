using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace xo
{
  
    public partial class Form1 : Form
    {  public Form1()
        {
            InitializeComponent();
        }
        int i = 2;int x = 1, O = 1;

        //color
        public void mo()
        {
            if (x > O)
            {
                label4.ForeColor = Color.Blue;
                label1.ForeColor = Color.Blue;
                label3.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;

            }
            else if (x < O)
            {
                label4.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.Blue;

            }
            else
            {
                label4.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }

        }
        //reset
        private void button5_Click(object sender, EventArgs e)
        {
            b1.Text = ""; b2.Text = ""; b6.Text = ""; b7.Text = ""; b8.Text = ""; b9.Text = "";
            b4.Text = ""; b3.Text = ""; b5.Text = ""; b4.Text = ""; b1.Text = "";
            b1.Enabled = true; b2.Enabled = true; b3.Enabled = true; b4.Enabled = true;
            b5.Enabled = true; b6.Enabled = true; b7.Enabled = true; b8.Enabled = true; b9.Enabled = true;
            b3.BackColor= Color.White; b1.BackColor = Color.White; b2.BackColor = Color.White;
            b4.BackColor = Color.White; b7.BackColor = Color.White; b8.BackColor = Color.White;
            b5.BackColor = Color.White; b6.BackColor = Color.White; b9.BackColor = Color.White;
        }
        //game
        public void button11_Click(object sender, EventArgs e)
        {
            Button bt=(Button)sender;
            
            if(i%2==0)
            {
                bt.Text = "X";
                i++;
                bt.BackColor = Color.DarkCyan;
            }
            else
            {
                bt.Text= "O"; i++;
                bt.BackColor = Color.DarkOrange;
            }
            bt.Enabled = false;

            if(b1.Text=="X"&&b2.Text=="X"&&b3.Text=="X")

            {
                MessageBox.Show("X is win ");
                label1.Text =(x).ToString();x++; mo();
                i = 2;
            }
            if (b5.Text == "X" && b6.Text == "X" && b4.Text == "X")

            {
                MessageBox.Show("X is win ");
                label1.Text = (x ).ToString();x++; i = 2; mo();
            }
            if (b9.Text == "X" && b8.Text == "X" && b7.Text == "X")

            {
                MessageBox.Show("X is win ");
                label1.Text = (x ).ToString();x++;  i = 2; mo();
            }
            if (b1.Text == "X" && b6.Text == "X" && b7.Text == "X")

            {
                MessageBox.Show("X is win ");
                label1.Text = (x ).ToString();x++;  i = 2; mo();
            }
                if (b2.Text == "X" && b5.Text == "X" && b8.Text == "X")

            {
                MessageBox.Show("X is win ");
                label1.Text = (x ).ToString();x++;  i = 2; mo();
            }
            if (b4.Text == "X" && b9.Text == "X" && b3.Text == "X")

            {
                MessageBox.Show("X is win ");
                label1.Text = (x ).ToString();x++;  i = 2; mo();
            }
            if (b1.Text == "X" && b5.Text == "X" && b9.Text == "X")

            {
                MessageBox.Show("X is win ");
                label1.Text = (x ).ToString();x++;  i = 2; mo();
            }
            if (b3.Text == "X" && b5.Text == "X" && b7.Text == "X")

            {
                MessageBox.Show("X is win ");
                label1.Text = (x ).ToString();x++;  i = 2; mo();
            }

            if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++;  i = 1; mo();
            }
            if (b5.Text == "O" && b6.Text == "O" && b4.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++; i = 1; mo();
            }
            if (b9.Text == "O" && b8.Text == "O" && b7.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++;  i = 1; mo();
            }
            if (b1.Text == "O" && b6.Text == "O" && b7.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++;  i = 1; mo();
            }
            if (b2.Text == "O" && b5.Text == "O" && b8.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++;  i = 1; mo();
            }
            if (b4.Text == "O" && b9.Text == "O" && b3.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++;  i = 1; mo();
            }
            if (b1.Text == "O" && b5.Text == "O" && b9.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++; i = 1; mo();
            }
            if (b3.Text == "O" && b5.Text == "O" && b7.Text == "O")

            {
                MessageBox.Show("O is win ");
                label2.Text = (O).ToString(); O++;  i = 1;mo();
            }
          

        }
    }
}

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

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button mo = (Button)sender;
           textBox1.Text=textBox1.Text+ mo.Text ;
            
        }
        double x, y,z;
        string op;

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
            textBox1.Focus(); 
            label1.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            y = double.Parse(textBox1.Text);
            button18.Focus();
            switch (op)
            {
                case "+":
                    {
                        z = x + y;
                        textBox1.Text = z.ToString();
                        label1.Text = label1.Text + " " + y + " = ";


                    }
                    break;
                case "-":
                    {
                        z = x - y;
                        textBox1.Text = z.ToString();
                        label1.Text = label1.Text + " " + y + " = ";
                    }
                    break;
                case "*":
                    {
                        z = x * y;
                        textBox1.Text = z.ToString();
                        label1.Text = label1.Text + " " + y + " = ";
                    }
                    break;
                case "/":
                    {
                        z = x / y;
                        textBox1.Text = z.ToString();
                        label1.Text = label1.Text + " " + y + " = ";
                    }
                    break;
            }

        }

        private void button17_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':  break;
                case '2':break;
               case '3': break;
                case '4': break;
                case '5': break;
                case '6': break;
                case '7': break;
                case '8': break;
                case '9': break;
                case '.': break;
                case '0':break;

                case '+': {
                        e.Handled = true;
                        button19.PerformClick();

                    }break;
                case '-':
                    {
                        e.Handled = true;
                        button12.PerformClick();

                    }
                    break;
                case '*':
                    {
                        e.Handled = true;
                        button1.PerformClick();

                    }
                    break;
                case '/':
                    {
                        e.Handled = true;
                        button11.PerformClick();

                    }
                    break;
                case (char)Keys.Back: break;

               case (char)Keys.Enter: { 
                    button17.PerformClick();
                    } break;

                    e.Handled = false;

                default:
                    {
                        e.Handled = true;
                        
                        
                       
                    }break;
               
            }
        }


        private void button19_Click(object sender, EventArgs e)
        {
           
            
            Button opp= (Button)sender;
            x =double.Parse( textBox1.Text);
            op = opp.Text;
            textBox1.Clear();
            char[] q = textBox1.Text.ToCharArray();
            label1.Text=x+" "+op;


                    }
    }
}

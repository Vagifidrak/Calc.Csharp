using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculyator_reqemli
{
    public partial class CALC : Form
    {

        double x, y;
        string netice;
        public CALC()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else {
                textBox1.Text += "1";
            }; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text= "4";
            }
            else
            {
                textBox1.Text += "4";
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
               else {
                textBox1.Text += "5";
            }; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            };  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }; 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0) {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            };
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (netice == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (netice == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (netice == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (netice == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "-";
            netice = "-";
            textBox1.Text = "0";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "*";
            netice = "*";
            textBox1.Text = "0";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "/";
            netice = "/";
            textBox1.Text = "0";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
           x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "+";
            netice = "+";
            textBox1.Text = "0";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string number_1 = "";
        int value = 0;
        bool actions = true;
        string number_2 = "";
        int value_2 = 0;
        bool fract = false;
        bool addition = false;
        bool subtraction = false;
        bool multiplication = false;
        bool division = false;


        private void button1_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "1";
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "1");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "2");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "2");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "3");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "3");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "4");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "4");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "5");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "5");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "6");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "6");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "7");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "7");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "8");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "8");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "9");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "9");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "0");
                textBox1.Text = number_1;
                value++;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "0");
                textBox1.Text = number_2;
                value_2++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = number_1.Insert(value, "00");
                textBox1.Text = number_1;
                value+=2;
            }
            else
            {
                number_2 = number_2.Insert(value_2, "00");
                textBox1.Text = number_2;
                value_2+=2;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (fract == false)
            {
                if (actions == true)
                {
                    number_1 = number_1.Insert(value, ",");
                    textBox1.Text = number_1;
                    value++;
                    fract = true;
                }
                else
                {
                    number_2 = number_2.Insert(value_2, ",");
                    textBox1.Text = number_2;
                    value_2++;
                    fract = true;
                }
            }
           

        }

        private void button13_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "+";        
        }

        private void button14_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "%";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "=";
        }
    }
}

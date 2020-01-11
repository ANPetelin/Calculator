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
    enum Action
    {
        Addition,
        Multiplication,
        Division,
        Balance,
        Power,
        Root
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string number_1 = "";
        bool actions = true;
        string number_2 = "";
        bool fract = false;
        Action action = Action.Addition;
        string memory_1 = "";
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "1";
                textBox1.Text = number_1;                
            }
            else
            {
                number_2 += "1";
                textBox1.Text = number_2;                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "2";
                textBox1.Text = number_1;                
            }
            else
            {
                number_2 += "2";
                textBox1.Text = number_2;                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "3";
                textBox1.Text = number_1;                
            }
            else
            {
                number_2 += "3";
                textBox1.Text = number_2;                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "4";
                textBox1.Text = number_1;                
            }
            else
            {
                number_2 += "4";
                textBox1.Text = number_2;                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "5";
                textBox1.Text = number_1;            
            }
            else
            {
                number_2 += "5";
                textBox1.Text = number_2;           
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "6";
                textBox1.Text = number_1;            
            }
            else
            {
                number_2 += "6";
                textBox1.Text = number_2;         
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "7";
                textBox1.Text = number_1;             
            }
            else
            {
                number_2 += "7";
                textBox1.Text = number_2;              
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "8";
                textBox1.Text = number_1;              
            }
            else
            {
                number_2 += "8";
                textBox1.Text = number_2;            
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "9";
                textBox1.Text = number_1;          
            }
            else
            {
                number_2 += "9";
                textBox1.Text = number_2;              
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "0";
                textBox1.Text = number_1;              
            }
            else
            {
                number_2 += "0";
                textBox1.Text = number_2;             
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 += "00";
                textBox1.Text = number_1;           
            }
            else
            {
                number_2 += "00";
                textBox1.Text = number_2;             
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (fract == false)
            {
                if (actions == true)
                {
                    number_1 += ",";
                    textBox1.Text = number_1;
                    fract = true;
                }
                else
                {
                    number_2 += ",";
                    textBox1.Text = number_2;
                    fract = true;
                }
            }
           

        }

        private void button13_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "+";
            action = Action.Addition;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "-";
            action = Action.Balance;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "*";
            action = Action.Multiplication;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "/";
            action = Action.Division;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            if (action == Action.Addition || action == Action.Balance)
            {
                number_2 = Convert.ToString(Convert.ToDouble(number_1) * Convert.ToDouble(number_2) / 100);
                textBox1.Text = number_2;
            }
            else
            {
                number_2 = Convert.ToString(Convert.ToDouble(number_2) / 100);
                textBox1.Text = number_2;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case Action.Addition:
                    {
                        number_1 = Convert.ToString(Convert.ToDouble(number_1) + Convert.ToDouble(number_2));
                        textBox1.Text = number_1;
                        number_2 = "";
                        actions = true;
                        fract = false;
                        break;
                    }
                case Action.Balance:
                    {
                        number_1 = Convert.ToString(Convert.ToDouble(number_1) - Convert.ToDouble(number_2));
                        textBox1.Text = number_1;
                        number_2 = "";
                        actions = true;
                        fract = false;
                        break;
                    }
                case Action.Multiplication:
                    {
                        number_1 = Convert.ToString(Convert.ToDouble(number_1) * Convert.ToDouble(number_2));
                        textBox1.Text = number_1;
                        number_2 = "";
                        actions = true;
                        fract = false;
                        break;
                    }
                case Action.Division:
                    {
                        number_1 = Convert.ToString(Convert.ToDouble(number_1) / Convert.ToDouble(number_2));
                        textBox1.Text = number_1;
                        number_2 = "";
                        actions = true;
                        fract = false;
                        break;
                    }
                case Action.Power:
                    {
                        number_1 = Convert.ToString(Math.Pow(Convert.ToDouble(number_1), Convert.ToDouble(number_2)));
                        textBox1.Text = number_1;
                        number_2 = "";
                        actions = true;
                        fract = false;
                        break;
                    }
                case Action.Root:
                    {
                        number_1 = Convert.ToString(Math.Pow(Convert.ToDouble(number_1), 1/Convert.ToDouble(number_2)));
                        textBox1.Text = number_1;
                        number_2 = "";
                        actions = true;
                        fract = false;
                        break;
                    }

            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            number_1 = "";
            textBox1.Text = number_1;
            actions = true;
            number_2 = "";
            fract = false;
            action = Action.Addition;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToString(1 / Convert.ToDouble(number_1));
            textBox1.Text = number_1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToString(Convert.ToDouble(number_1)* Convert.ToDouble(number_1));
            textBox1.Text = number_1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToString(Math.Sqrt(Convert.ToDouble(number_1)));
            textBox1.Text = number_1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                if (number_1.Contains("-"))
                {
                    number_1 = number_1.Replace("-", "");
                    textBox1.Text = number_1;
                }
                else
                {
                    number_1 = number_1.Insert(0, "-");
                    textBox1.Text = number_1;
                }
            }
            else
            {
                if (number_2.Contains("-"))
                {
                    number_2 = number_2.Replace("-", "");
                    textBox1.Text = number_2;
                }
                else
                {
                    number_2 = number_2.Insert(0, "-");
                    textBox1.Text = number_2;
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            if (actions == true)
            {
                int value_1 = number_1.Length;
                number_1 = number_1.Remove(value_1-1);
                textBox1.Text = number_1;
            }
            else
            {
                int value_2 = number_2.Length;
                number_2 = number_2.Remove(value_2 - 1);
                textBox1.Text = number_2;
            }
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                memory_1 = textBox1.Text;
                number_1 = "";
                textBox1.Text = number_1;
            }
            else
            {
                memory_1 = textBox1.Text;
                number_2 = "";
                textBox1.Text = number_2;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            memory_1 = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (actions == true)
            {
                number_1 = memory_1;
                textBox1.Text = number_1;
            }
            else
            {
                number_2 = memory_1;
                textBox1.Text = number_2;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "^";
            action = Action.Power;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            actions = false;
            fract = false;
            textBox1.Text = "root";
            action = Action.Root;
        }
    }
}

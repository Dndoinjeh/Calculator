using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davidsCalculator
{
    public partial class Calculator : Form
    {
        double firstNumber;
        string Opertation;
  


        public Calculator()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }


        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }


        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }



        private void bEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double Result;

            secondNumber = Convert.ToDouble(textBox1.Text);

            if (Opertation == "+")
            {
                Result = (firstNumber + secondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }

            if (Opertation == "-")
            {
                Result = (firstNumber - secondNumber);
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }

            if (Opertation == "*")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "You cannot multiply by zero!";
                }
                else
                {
                    Result = (firstNumber * secondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    firstNumber = Result;
                }
            }

            if (Opertation == "/")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "You cannot divide by zero!";
                }
                else
                {
                    Result = (firstNumber / secondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    firstNumber = Result;
                }
            }

        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Opertation = "/";

        }

        private void bMult_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Opertation = "*";
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Opertation = "-";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Opertation = "+";

        }

        private void bClr_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}

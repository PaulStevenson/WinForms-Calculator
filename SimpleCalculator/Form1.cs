using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstNum;
        string operation;



        public Form1()

        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
      
        private void numberOne_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = null;
                textBox1.Text = textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {

        }

        private void plusOperator_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "+";

        }

        private void minusOperator_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "-";
        }

        private void multiplyOperator_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "*";
        }

        private void divideOperator_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "/";
        }

        private void dudButton_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "%";
        }

        private void equalsOperator_Click(object sender, EventArgs e)
        {
            double result = 0;

            if (operation == "+")
            {
                result = firstNum + Convert.ToDouble(textBox1.Text);
            }

            else if (operation == "-")
            {
                result = firstNum - Convert.ToDouble(textBox1.Text);
            }

            else if (operation == "*")
            {
                result = firstNum * Convert.ToDouble(textBox1.Text);
            }

            else if (operation == "%")
            {
                result = firstNum % Convert.ToDouble(textBox1.Text);
            }

            else if (operation == "/")
            {
                if (textBox1.Text == "0")
                {
                    MessageBox.Show("Stop that!");
                }
                else
                    result = firstNum / Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = result.ToString();


        }
    }
}

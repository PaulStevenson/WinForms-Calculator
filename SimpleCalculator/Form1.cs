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
        bool HasBeenClicked = false;

        public object ScriptManager { get; private set; }

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
            string dot = ".";

            if (!textBox1.Text.Contains(dot))
            {
                textBox1.Text = textBox1.Text + ".";
            }
            else
                MessageBox.Show("You can only use one dot");
        }

        private void plusOperator_Click(object sender, EventArgs e)
        {
            string plus = "+";

            if (!textBox1.Text.Contains(plus))
            {
                firstNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "+";
                operation = "+";
            }
            else
                MessageBox.Show("Opps, you've already started an addition. Select the next number :)");
        }

        private void minusOperator_Click(object sender, EventArgs e)
        {
            string minus = "-";

            if (!textBox1.Text.Contains(minus))
            {
                firstNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "-";
                operation = "-";
            }
            else
                MessageBox.Show("Opps, you've already started a subtraction. Select the next number :)");
        }

        private void multiplyOperator_Click(object sender, EventArgs e)
        {
            string multi = "-";

            if (!textBox1.Text.Contains(multi))
            {
                firstNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "*";
                operation = "*";
            }
            else
                MessageBox.Show("Opps, you've already started a multiplication. Select the next number :)");
        }

        private void divideOperator_Click(object sender, EventArgs e)
        {
            string divide = "/";

            if (!textBox1.Text.Contains(divide))
            {
                firstNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "/";
                operation = "/";
            }
            else
                MessageBox.Show("Opps, you've already started a dividion. Select the next number :)");
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
                    MessageBox.Show("Are you trying to break everything?");
                }
                else
                    result = firstNum / Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = result.ToString();


        }




        //FORGOT FOR NOW

        private void preventMultipleOperatorPresses(object sender, EventArgs e)
        {
            

        }


        //private void preventMultipleOperatorPresses(object sender, EventArgs e)
        //{
        //    List<string> operators = new List<string>() { "+", "-", "X", "/" };

        //    foreach (string op in operators)
        //    {
        //        if (textBox1.Text.Contains(op))
        //        {
        //            MessageBox.Show("Select a numerical value");
        //        }


        //    }

        //}
    }
}

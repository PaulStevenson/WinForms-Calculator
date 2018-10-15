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
        double FirstNum;
        double SecondNum;
        string Operation;
        double Result;


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

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1 + ".";
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

        private void plusOperator_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "+";
            Operation = "+";
            
        }

        private void equalsOperator_Click(object sender, EventArgs e)
        {
            
               
        }
    }
}

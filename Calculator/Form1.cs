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
        private string operation;
        private int num1;
        private int num2;
        private int result;
        
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn9.Text;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "x";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(txtResult.Text);
            txtResult.Clear();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtResult.Text);
            switch (operation)
            { 
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "x":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            txtResult.Text = result.ToString();
        }


    }
}

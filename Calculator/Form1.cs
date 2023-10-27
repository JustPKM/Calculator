using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string operation;
        private double num1;
        private double num2;
        private double result;
        #region Các phím số
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "0";
            else
            {
                txtResult.Text += btn0.Text;
                txtShow.Text += btn0.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn1.Text;
            txtShow.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn2.Text;
            txtShow.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn3.Text;
            txtShow.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn4.Text;
            txtShow.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn5.Text;
            txtShow.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn6.Text;
            txtShow.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn7.Text;
            txtShow.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn8.Text;
            txtShow.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn9.Text;
            txtShow.Text += btn9.Text;
        }
        #endregion
        #region Các toán tử
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text += button.Text;
            txtResult.Clear();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text += button.Text;
            txtResult.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text += button.Text;
            txtResult.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text += button.Text;
            txtResult.Clear();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtResult.Text);
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
        #endregion
        //Nut Clear sai chuc nang
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
                txtShow.Text = txtShow.Text.Remove(txtShow.Text.Length - 1);
            }
            if(txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtShow.Clear();
            txtResult.Text = "0";
        }

        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResult.Text) * -1;
            txtResult.Text = num1.ToString();
            txtShow.Text = num1.ToString();
            
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResult.Text += ",";
            txtShow.Text += ",";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResult.Text) / 100;
            txtResult.Text = num1.ToString();
            txtShow.Text = num1.ToString();
        }
    }
}

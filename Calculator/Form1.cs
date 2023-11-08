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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private string operation = "";
        private double num1;
        private double num2;
        private double result = 0;
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
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn2.Text;
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text += btn9.Text;
        }
        #endregion
        #region Các toán tử
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text = num1.ToString() + button.Text;
            txtResult.Clear();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text = num1.ToString() + button.Text;
            txtResult.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text = num1.ToString() + button.Text;
            txtResult.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = double.Parse(txtResult.Text);
            txtShow.Text = num1.ToString() + button.Text;
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
            txtShow.Text = num1.ToString() + operation.ToString() + num2.ToString() + " =";
            txtResult.Text = result.ToString();
            
        }
        #endregion
        #region Các phím chức năng
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtShow.Clear();
            txtResult.Text = "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if(!txtResult.Text.Contains("."))
                txtResult.Text += ".";
        }
        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "0")
            {
                result = double.Parse(txtResult.Text) * -1;
                txtResult.Text = result.ToString();
            }
        }
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResult.Text) / 100;
            txtResult.Text = num1.ToString();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            if(txtResult.Text == "")
                txtResult.Text = "0";
        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            double res = double.Parse(txtResult.Text);
            if (txtResult.Text != "0" && res != 0)
            {
                txtResult.Text = (1 / res).ToString();
            }
            else
                txtResult.Text = "Cannot divide by zero";
        }
        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double result = double.Parse(txtResult.Text);
                if (result >= 0)
                {
                    result = Math.Sqrt(result);
                    txtResult.Text = result.ToString();
                }
                else
                    txtResult.Text = "Invalid value";
            }
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double result = Math.Pow(double.Parse(txtResult.Text), 2);
                txtResult.Text = result.ToString();
            }
        }
        #endregion

    }
}

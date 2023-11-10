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
        private double result = 0;
        private double preValue = 0;
        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtResult.Text == "0")
            {
                txtResult.Clear();
            }
            txtResult.Text += btn.Text;
        }
        #region Các phím số
        private void btn0_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ButtonNumber_Click(sender, e);
        }
        #endregion

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double num = double.Parse(txtResult.Text);
            if (operation == "+")
                result += num;
            else if (operation == "-")
                result -= num;
            else if (operation == "x")
                result *= num;
            else if (operation == "/")
                result /= num;
            else
                result = num;

            operation = btn.Text;
            txtShow.Text = result.ToString() + operation.ToString();
            preValue = result;
            txtResult.Clear();
            
        }
        #region Các toán tử
        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender,e);
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender,e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender ,e);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender ,e);
        }
        #endregion
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtResult.Text);
            if (operation == "+")
                result += num;
            else if (operation == "-")
                result -= num;
            else if (operation == "x")
                result *= num;
            else if (operation == "/")
                result /= num;
            else
                result = num;

            txtShow.Text = preValue.ToString() + operation.ToString() + num.ToString() + " =";
            txtResult.Text = result.ToString();
            preValue = result;
            operation = "";
            
        }
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
            double num1 = double.Parse(txtResult.Text) / 100;
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

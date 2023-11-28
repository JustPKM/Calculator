using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calculator
{
    public partial class Calculator : Form
    {
        bool sidebarExpand;
        bool hasResult = false;
        private string operation = "";
        private double result = 0;
        private double val,preValue = 0;
        string op;
        
        public Calculator()
        {
            InitializeComponent();
            this.KeyDown += Calculator_KeyDown;
        }


        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtResult.Text == "0")
            {
                txtResult.Clear();
            }
            if (hasResult)
            {
                txtShow.Clear();
                txtResult.Text = btn.Text;
                hasResult = false;
            }
            else
            {
                txtResult.Text += btn.Text;
            }
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
            if (operation != "")
            {
                double num = double.Parse(txtResult.Text);
                val = num;
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


                op = operation;
                txtShow.Text = preValue.ToString() + operation.ToString() + num.ToString() + " =";
                txtResult.Text = result.ToString();
                preValue = result;
                operation = "";
            }
            else
            {
                if (txtShow.Text == "")
                {
                    result = double.Parse(txtResult.Text);
                    txtShow.Text = result.ToString();
                }
                else
                {
                    if (op == "+")
                        result += val;
                    else if (op == "-")
                        result -= val;
                    else if (op == "x")
                        result *= val;
                    else if (op == "/")
                        result /= val; 
                    else
                        result = val;

                    txtShow.Text = preValue.ToString() + op.ToString() + val.ToString() + " =";
                    txtResult.Text = result.ToString();
                    preValue = result;
                    
                }
            }
            hasResult = true;
            rtbHistory.AppendText(txtShow.Text);
            rtbHistory.AppendText(" "+ txtResult.Text + "\n");
            lblStatus.Text = "";
        }
        #region Các phím chức năng
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            rtbHistory.Clear();
            if (lblStatus.Text == "")
            {
                lblStatus.Text = "There's no history yet";
            }
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

        private void siderbarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    siderbarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    siderbarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            siderbarTimer.Start();
            if (!sidebarExpand)
            {
                lblType.Hide();
            }else { 
                lblType.Show();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTemperatureMode_Click(object sender, EventArgs e)
        {
            Length f = new Length();
            this.Hide();
            f.Show();
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnStandardMode_Click(object sender, EventArgs e)
        {
            siderbarTimer.Start();
            sidebarExpand = true;
            siderbarTimer_Tick(sender, e);
            if (sidebarExpand && sidebar.Width == sidebar.MaximumSize.Width)
            {
                lblType.Hide();
            }
            else
            {
                lblType.Show();
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Handled)
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad0:
                    case Keys.D0:
                        btn0.PerformClick();
                        break;
                    case Keys.NumPad1:
                    case Keys.D1:
                        btn1.PerformClick();
                        break;
                    case Keys.NumPad2:
                    case Keys.D2:
                        btn2.PerformClick();
                        break;
                    case Keys.NumPad3:
                    case Keys.D3:
                        btn3.PerformClick();
                        break;
                    case Keys.NumPad4:
                    case Keys.D4:
                        btn4.PerformClick();
                        break;
                    case Keys.NumPad5:
                    case Keys.D5:
                        btn5.PerformClick();
                        break;
                    case Keys.NumPad6:
                    case Keys.D6:
                        btn6.PerformClick();
                        break;
                    case Keys.NumPad7:
                    case Keys.D7:
                        btn7.PerformClick();
                        break;
                    case Keys.NumPad8:
                    case Keys.D8:
                        btn8.PerformClick();
                        break;
                    case Keys.NumPad9:
                    case Keys.D9:
                        btn9.PerformClick();
                        break;
                    case Keys.Add:
                    case Keys.Oemplus:
                        btnPlus.PerformClick();
                        break;
                    case Keys.Subtract:
                    case Keys.OemMinus:
                        btnMinus.PerformClick();
                        break;
                    case Keys.Multiply:
                        btnMultiply.PerformClick();
                        break;
                    case Keys.Divide:
                    case Keys.OemQuestion:
                        btnDivision.PerformClick();
                        break;
                    case Keys.Enter:
                        btnEqual_Click(sender, e);
                        break;
                    case Keys.Back:
                        btnBackSpace.PerformClick();
                        break;
                    case Keys.Escape:
                        btnAllClear.PerformClick();
                        break;
                    default:
                        return;
                }
                e.Handled = true;
            }
        }
    }
}

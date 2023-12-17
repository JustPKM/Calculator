using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Scientific : Form
    {
        public Scientific()
        {
            InitializeComponent();
            this.KeyDown += Scientific_KeyDown;
            this.Size = MinimumSize;
        }

        private bool sidebarExpand, hasResult = false, formExpand = false;
        private bool AngleType = true, ModeType = true;
        private string oldOperation, operation = "";
        private double result = 0;
        private double value, preValue = 0;

        private void Scientific_Click(object sender, EventArgs e)
        {
            if (sender is Button)
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
            btnEqual.Focus();
        }

        private void Scientific_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTemperatureMode_Click(object sender, EventArgs e)
        {
            Temperature t = new Temperature();
            this.Hide();
            t.Show();
        }
        private void btnStandardMode_Click(object sender, EventArgs e)
        {
            Calculator f = new Calculator();
            this.Hide();
            f.Show();
        }
        private void btnLengthMode_Click(object sender, EventArgs e)
        {
            Length l = new Length();
            this.Hide();
            l.Show();
        }
        private void btnScientificMode_Click(object sender, EventArgs e)
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

        #region Các nút chức năng
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            if (txtResult.Text == "")
                txtResult.Text = "0";
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
            if (lblStatus.Text == "")
            {
                lblStatus.Text = "There's no history yet";
            }
            txtResult.Clear();
            txtShow.Clear();
            txtResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtResult.Text) / 100;
            txtResult.Text = num1.ToString();
        }

        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "0")
            {
                result = double.Parse(txtResult.Text) * -1;
                txtResult.Text = result.ToString();
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
                txtResult.Text += ".";
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
            else if (operation == "mod")
                result %= num;
            else
                result = num;

            operation = btn.Text;
            txtShow.Text = result.ToString() + " " + operation.ToString();
            preValue = result;
            txtResult.Clear();

        }
        #region Toán tử
        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }
        #endregion

        #region Toán lượng giác
        private void btnLogarit_Click(object sender, EventArgs e)
        {
            txtShow.Text = btnLogarit.Text + " " + txtResult.Text + " =";
            txtResult.Text = Convert.ToString(Math.Log(double.Parse(txtResult.Text)));
            btnEqual.Focus();
        }

        private void btnLN_Click(object sender, EventArgs e)
        {
            txtShow.Text = btnLN.Text + " " + txtResult.Text + " =";
            txtResult.Text = Convert.ToString(Math.Log10(double.Parse(txtResult.Text)));
            btnEqual.Focus();
        }
        private void Trigonometry(string buttonText, Func<double, double> operation, Func<double, double> hyperbolicOperation, bool useDegrees)
        {
            txtShow.Text = $"{buttonText} {txtResult.Text} =";

            double angle = double.Parse(txtResult.Text);

            if (useDegrees)
            {
                angle *= Math.PI / 180;
            }

            double result;

            if (ModeType) 
            {
                if (buttonText.Equals("sin"))
                {
                    result = operation(angle);
                }
                else if (buttonText.Equals("cos"))
                {
                    result = operation(angle);
                }
                else if (buttonText.Equals("tan"))
                {
                    result = operation(angle);
                }
                else if (buttonText.Equals("cot"))
                {
                    result = operation(angle);
                }
                else
                {
                    txtResult.Text = "Invalid button input";
                    return;
                }
            }
            else
            {
                if (buttonText.Equals("sinh")) {
                    result = hyperbolicOperation(angle);
                }
                else if (buttonText.Equals("cosh")) {
                    result = hyperbolicOperation(angle);
                }
                else if (buttonText.Equals("tanh")) {
                    result = hyperbolicOperation(angle);
                }
                else if (buttonText.Equals("coth")) {
                    result = hyperbolicOperation(angle);
                }
                else
                {
                    txtResult.Text = "Invalid button input";
                    return;
                }

            }
            txtResult.Text = result.ToString();
            btnEqual.Focus();
        }
        private void Hyperbolic(string buttonText, Func<double, double> operation, Func<double, double> hyperbolicOperation, bool useDegrees)
        {
            txtShow.Text = $"{buttonText} {txtResult.Text} =";

            double angle = double.Parse(txtResult.Text);
            if (useDegrees)
            {
                if (buttonText.EndsWith("h"))
                {
                    if (Math.Abs(angle) > 1)
                    {
                        txtResult.Text = "Must be between -1 and 1";
                        return;
                    }
                    txtResult.Text = Convert.ToString(hyperbolicOperation(angle) * (180 / Math.PI));
                }
                else
                {
                    txtResult.Text = Convert.ToString(operation(angle) * (180 / Math.PI));
                }
            }
            else
            {
                if (buttonText.EndsWith("h"))
                {
                    if (Math.Abs(angle) > 1)
                    {
                        txtResult.Text = "Must be between -1 and 1";
                        return;
                    }
                    txtResult.Text = Convert.ToString(hyperbolicOperation(angle));
                }
                else
                {
                    txtResult.Text = Convert.ToString(operation(angle));
                }
            }
            btnEqual.Focus();
        }
        private void btnHyp_Click(object sender, EventArgs e)
        {
            ModeType = !ModeType;

            btnHyp.Text = ModeType ? "hyp" : "tri";
            btnSin.Text = ModeType ? "sin" : "sinh";
            btnCos.Text = ModeType ? "cos" : "cosh";
            btnTan.Text = ModeType ? "tan" : "tanh";
            btnCotan.Text = ModeType ? "cot" : "coth";
            btnASin.Text = ModeType ? "Asin" : "Asinh";
            btnACos.Text = ModeType ? "Acos" : "Acosh";
            btnATan.Text = ModeType ? "Atan" : "Atanh";
            btnACot.Text = ModeType ? "Acot" : "Acoth";
        }

        private void btnRadDeg_Click(object sender, EventArgs e)
        {
            AngleType = !AngleType;
            btnRadDeg.Text = AngleType ? "deg" : "rad";

        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            Trigonometry(btnSin.Text,Math.Sin,Math.Sinh, AngleType);
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            Trigonometry(btnCos.Text,Math.Cos,Math.Cosh,AngleType);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            Trigonometry(btnTan.Text,Math.Tan,Math.Tanh,AngleType);
        }

        private void btnCotan_Click(object sender, EventArgs e)
        {
            Trigonometry(btnCotan.Text, angle => 1 / Math.Tan(angle), angle => 1 / Math.Tanh(angle), AngleType);
        }
        private void btnASin_Click(object sender, EventArgs e)
        {
            Hyperbolic(btnASin.Text, Math.Asin, angle => Math.Log(angle + Math.Sqrt(angle * angle + 1)), AngleType);
        }
        private void btnACos_Click(object sender, EventArgs e)
        {
            Hyperbolic(btnACos.Text, Math.Acos, angle => Math.Log(angle + Math.Sqrt(angle * angle - 1)), AngleType);
        }

        private void btnATan_Click(object sender, EventArgs e)
        {
            Hyperbolic(btnATan.Text, Math.Atan, angle => 0.5 * Math.Log((1 + angle) / (1 - angle)), AngleType);
        }

        private void btnACot_Click(object sender, EventArgs e)
        {
            Hyperbolic(btnACot.Text, angle => Math.Atan(1 / angle), angle => 0.5 * Math.Log((angle + 1) / (angle - 1)), AngleType);
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            txtShow.Text = btnEXP.Text + " " + txtResult.Text + " =";
            txtResult.Text = Convert.ToString(Math.Exp(double.Parse(txtResult.Text)));
            btnEqual.Focus();
        }
        #endregion
        private void btnMenu_Click(object sender, EventArgs e)
        {
            siderbarTimer.Start();
            if (!sidebarExpand)
            {
                lblType.Hide();
            }
            else
            {
                lblType.Show();
            }
        }
        private void Scientific_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnEqual;
            this.AcceptButton = btnEqual;
        }

        private void lstHistory_Click(object sender, EventArgs e)
        {
            string show = "";
            string res = "";
            Calculator.Result_Showing(lstHistory.SelectedItem.ToString(), ref show, ref res);
            txtShow.Text = show + "=";
            txtResult.Text = res;
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (formExpand)
            {
                this.Size = MinimumSize;
            }
            else
            {
                this.Size = MaximumSize;
            }
            formExpand = !formExpand;
        }

        private void siderbarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    siderbarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    siderbarTimer.Stop();
                }
            }
        }

        private void Scientific_KeyDown(object sender, KeyEventArgs e)
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
                    case Keys.Back:
                        btnBackSpace.PerformClick();
                        break;
                    case Keys.Escape:
                        btnAllClear.PerformClick();
                        break;
                    case Keys.F1:
                        btnMenu_Click(sender,e);
                        break;
                    default:
                        return;
                }
                e.Handled = true;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                double num = double.Parse(txtResult.Text);
                value = num;
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


                oldOperation = operation;
                txtShow.Text = preValue.ToString() + " " + operation.ToString() + " " + num.ToString() + " =";
                txtResult.Text = result.ToString();
                preValue = result;
                operation = "";
            }
            else
            {
                if (txtShow.Text == "" || string.IsNullOrEmpty(oldOperation))
                {
                    result = double.Parse(txtResult.Text);
                    txtShow.Text = result.ToString() + " =";
                }
                else
                {
                    if (oldOperation == "+")
                        result += value;
                    else if (oldOperation == "-")
                        result -= value;
                    else if (oldOperation == "x")
                        result *= value;
                    else if (oldOperation == "/")
                        result /= value;
                    else
                        result = value;

                    txtShow.Text = preValue.ToString() + " " + oldOperation.ToString() + " " + value.ToString() + " =";
                    txtResult.Text = result.ToString();
                    preValue = result;

                }
            }
            hasResult = true;
            lstHistory.Items.Add(txtShow.Text + " " + txtResult.Text);
            lblStatus.Text = "";
            btnEqual.Focus();
        }
        private void HandlingResultMode(object sender, EventArgs e)
        {
            
        }
    }
}

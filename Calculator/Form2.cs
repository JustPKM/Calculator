using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Length : Form
    {
        private double result = 0;
        private bool sidebarExpand;
        Converting cs;

        public Length()
        {
            InitializeComponent();
        }
        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            if (lblInput.Text != "0")
            {
                result = double.Parse(lblInput.Text) * -1;
                lblInput.Text = result.ToString();
            }
        }

        private void Length_Load(object sender, EventArgs e)
        {
            cbbConvertUnits.Text = "Celsius";
            cbbConvertedUnits.Text = "Fahrenheit";
            if (cbbConvertUnits.Text == "Celsius")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Fahrenheit")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (lblInput.Text.Length > 0)
            {
                lblInput.Text = lblInput.Text.Substring(0, lblInput.Text.Length - 1);
            }
            if (lblInput.Text == "")
                lblInput.Text = "0";
            if (cbbConvertUnits.Text == "Celsius")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Fahrenheit")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput.Text = "0";
            if (cbbConvertUnits.Text == "Celsius")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Fahrenheit")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
        }

        private void Length_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (lblInput.Text == "0")
                {
                    lblInput.Text = "";
                }
                lblInput.Text += btn.Text;
                if (cbbConvertUnits.Text == "Celsius")
                {
                    lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
                }
                else if (cbbConvertUnits.Text == "Fahrenheit")
                {
                    lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
                }
                else
                {
                    lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
                }
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!lblInput.Text.Contains("."))
                lblInput.Text += ".";
        }
        private double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            cs = new Converting();
            switch (fromUnit)
            {
                case "Celsius":
                    switch (toUnit)
                    {
                        case "Fahrenheit":
                            return cs.CelsiusToFahrenheit(value);
                        case "Kelvin":
                            return cs.CelsiusToKelvin(value);
                        default:
                            return value; // No conversion needed
                    }
                case "Fahrenheit":
                    switch (toUnit)
                    {
                        case "Celsius":
                            return cs.FahrenheitToCelsius(value);
                        case "Kelvin":
                            return cs.FahrenheitToKelvin(value);
                        default:
                            return value; // No conversion needed
                    }
                case "Kelvin":
                    switch (toUnit)
                    {
                        case "Celsius":
                            return cs.KelvinToCelsius(value);
                        case "Fahrenheit":
                            return cs.KelvinToFahrenheit(value);
                        default:
                            return value; // No conversion needed
                    }
                default:
                    return value; // No conversion needed
            }
        }

        private void cbbConvertUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbConvertUnits.Text == "Celsius")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Fahrenheit")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
        }

        private void cbbConvertedUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbConvertUnits.Text == "Celsius")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Fahrenheit")
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else
            {
                lblOutput.Text = ConvertTemperature(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
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

        private void btnTemperatureMode_Click(object sender, EventArgs e)
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

        private void btnStandardMode_Click(object sender, EventArgs e)
        {
            Calculator f = new Calculator();
            this.Hide();
            f.Show();
        }

        private void Length_KeyDown(object sender, KeyEventArgs e)
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
                    case Keys.Back:
                        btnBackSpace.PerformClick();
                        break;
                    default:
                        return;
                }
                e.Handled = true;
            }
        }

        private void Length_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

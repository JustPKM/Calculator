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
    public partial class Length : Form
    {
        private bool sidebarExpand;
        Converting cs;
        public Length()
        {
            InitializeComponent();
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
                Output();
            }
        }

        private void cbbConvertUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            Output();
        }

        private void cbbConvertedUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            Output();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (lblInput.Text.Length > 0)
            {
                lblInput.Text = lblInput.Text.Substring(0, lblInput.Text.Length - 1);
            }
            if (lblInput.Text == "")
                lblInput.Text = "0";

            Output();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput.Text = "0";
            Output();
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!lblInput.Text.Contains("."))
                lblInput.Text += ".";
        }
        private double ConvertDistance(double value, string fromUnit, string toUnit)
        {
            cs = new Converting();
            switch (fromUnit)
            {
                case "Kilometers":
                    switch (toUnit)
                    {
                        case "Meters":
                            return cs.KilometersToMeters(value);
                        case "Centimeters":
                            return cs.KilometersToCentimeters(value);
                        case "Milimeters":
                            return cs.KilometersToMilimeters(value);
                        case "Inches":
                            return cs.KilometersToInches(value);
                        case "Miles":
                            return cs.KilometersToMiles(value);
                        default:
                            return value; // No conversion needed
                    }
                case "Meters":
                    switch (toUnit)
                    {
                        case "Kilometers":
                            return cs.MetersToKilometers(value);
                        case "Centimeters":
                            return cs.MetersToCentimeters(value);
                        case "Milimeters":
                            return cs.MetersToMilimeters(value);
                        case "Inches":
                            return cs.MetersToInches(value);
                        case "Miles":
                            return cs.MetersToMiles(value);
                        default:
                            return value; // No conversion needed
                    }
                case "Centimeters":
                    switch (toUnit)
                    {
                        case "Kilometers":
                            return cs.CentimetersToKilometers(value);
                        case "Meters":
                            return cs.CentimetersToMeters(value);
                        case "Milimeters":
                            return cs.CentimetersToMilimeters(value);
                        case "Inches":
                            return cs.CentimetersToInches(value);
                        case "Miles":
                            return cs.CentimetersToMiles(value);
                        default:
                            return value; // No conversion needed
                    }
                case "Milimeters":
                    switch (toUnit)
                    {
                        case "Kilometers":
                            return cs.MilimetersToKilometers(value);
                        case "Meters":
                            return cs.MilimetersToMeters(value);
                        case "Centimeters":
                            return cs.MilimetersToCentimeters(value);
                        case "Inches":
                            return cs.MilimetersToInches(value);
                        case "Miles":
                            return cs.MilimetersToMiles(value);
                        default:
                            return value; // No conversion needed
                    }
                case "Inches":
                    switch(toUnit)
                    {
                        case "Kilometers":
                            return cs.InchesToKilometers(value);
                        case "Meters":
                            return cs.InchesToMeters(value);
                        case "Milimeters":
                            return cs.InchesToMilimeters(value);
                        case "Centimeters":
                            return cs.InchesToCentimeters(value);
                        case "Miles":
                            return cs.InchesToMiles(value);
                        default:
                            return value; // No conversion needed
                    }
                case "Miles":
                    switch (toUnit)
                    {
                        case "Kilometers":
                            return cs.MilesToKilometers(value);
                        case "Meters":
                            return cs.MilesToMeters(value);
                        case "Milimeters":
                            return cs.MilesToMilimeters(value);
                        case "Inches":
                            return cs.MilesToInches(value);
                        case "Centimeters":
                            return cs.MilesToCentimeters(value);
                        default:
                            return value; // No conversion needed
                    }
                default:
                    return value; // No conversion needed
            }
        }
        private void Output()
        {
            if (cbbConvertUnits.Text == "Meters")
            {
                lblOutput.Text = ConvertDistance(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Kilometers")
            {
                lblOutput.Text = ConvertDistance(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Centimeters")
            {
                lblOutput.Text = ConvertDistance(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Milimeters")
            {
                lblOutput.Text = ConvertDistance(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else if (cbbConvertUnits.Text == "Inches")
            {
                lblOutput.Text = ConvertDistance(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
            else
            {
                lblOutput.Text = ConvertDistance(double.Parse(lblInput.Text), cbbConvertUnits.Text, cbbConvertedUnits.Text).ToString();
            }
        }

        private void Length_Load(object sender, EventArgs e)
        {
            cbbConvertUnits.Text = "Meters";
            cbbConvertedUnits.Text = "Milimeters";
            Output();
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

        private void btnStandardMode_Click(object sender, EventArgs e)
        {
            Calculator f = new Calculator();
            this.Hide();
            f.Show();
        }

        private void btnScientificMode_Click(object sender, EventArgs e)
        {
            Scientific s = new Scientific();
            this.Hide();
            s.Show();
        }

        private void btnTemperatureMode_Click(object sender, EventArgs e)
        {
            Temperature t = new Temperature();
            this.Hide();
            t.Show();
        }

        private void btnLengthMode_Click(object sender, EventArgs e)
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
    }
}

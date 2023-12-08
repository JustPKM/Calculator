using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Converting
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return Math.Round((celsius * 9 / 5) + 32,2);
        }

        // Hàm chuyển đổi từ Fahrenheit sang Celsius
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return Math.Round((fahrenheit - 32) * 5 / 9,2);
        }

        // Hàm chuyển đổi từ Celsius sang Kelvin
        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        // Hàm chuyển đổi từ Kelvin sang Celsius
        public double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        // Hàm chuyển đổi từ Fahrenheit sang Kelvin
        public double FahrenheitToKelvin(double fahrenheit)
        {
            return CelsiusToKelvin(FahrenheitToCelsius(fahrenheit));
        }

        // Hàm chuyển đổi từ Kelvin sang Fahrenheit
        public double KelvinToFahrenheit(double kelvin)
        {
            return CelsiusToFahrenheit(KelvinToCelsius(kelvin));
        }

        //Độ dài

        //Hàm chuyển đổi từ Met 
        public double MetersToKilometers(double m) 
        { 
            return m * 0.001;
        }
        public double MetersToCentimeters(double m)
        {
            return m * 100;
        }
        public double MetersToMilimeters(double m)
        {
            return m * 1000;
        }
        public double MetersToInches(double m)
        {
            return m * 39.3701;
        }
        public double MetersToMiles(double m)
        {
            return m * 0.000621371;
        }
        public double MetersToFeet(double m)
        {
            return m / 0.3048;
        }
        //Hàm chuyển đổi từ Milimet 
        public double MilimetersToKilometers(double m)
        {
            return m * 0.000001;
        }
        public double MilimetersToMeters(double m)
        {
            return m * 0.001;
        }
        public double MilimetersToCentimeters(double m)
        {
            return m * 0.1;
        }
        public double MilimetersToInches(double m)
        {
            return m * 0.0393701;
        }
        public double MilimetersToMiles (double m)
        {
            return m * 0.000000621371;
        }
        public double MilimetersToFeet(double m)
        {
            return m / 304.8;
        }
        //Hàm chuyển đổi từ Centimet 
        public double CentimetersToKilometers(double m)
        {
            return m * 0.00001;
        }
        public double CentimetersToMeters(double m)
        {
            return m * 0.01;
        }
        public double CentimetersToMilimeters(double m)
        {
            return m * 10;
        }
        public double CentimetersToInches(double m)
        {
            return m * 0.393701;
        }
        public double CentimetersToMiles(double m)
        {
            return m * 0.00000621371;
        }
        public double CentimetersToFeet(double m)
        {
            return m / 30.48;
        }
        //Hàm chuyển đổi từ Kilomet
        public double KilometersToMeters(double m)
        {
            return m * 1000;
        }
        public double KilometersToCentimeters(double m)
        {
            return m * 100000;
        }
        public double KilometersToMilimeters(double m)
        {
            return m * 1000000;
        }
        public double KilometersToInches(double m)
        {
            return m * 39370.1;
        }
        public double KilometersToMiles(double m)
        {
            return m * 0.621371;
        }
        public double KilometersToFeet(double m)
        {
            return m / 0.000348;
        }
        //Hàm chuyển đổi từ Inches
        public double InchesToKilometers(double m)
        {
            return m * 0.0000254;
        }
        public double InchesToMeters(double m)
        {
            return m * 0.0254;
        }
        public double InchesToCentimeters(double m)
        {
            return m * 2.54;
        }
        public double InchesToMilimeters(double m)
        {
            return m * 25.4;
        }
        public double InchesToMiles(double m)
        {
            return m * 0.000015782;
        }
        public double InchesToFeet(double m)
        {
            return m / 0.000189394;
        }
        //Hàm chuyển đổi từ Miles
        public double MilesToKilometers(double m)
        {
            return m * 1.609344;
        }
        public double MilesToMeters(double m)
        {
            return m * 1609.344;
        }
        public double MilesToCentimeters(double m)
        {
            return m * 160934.4;
        }
        public double MilesToMilimeters(double m)
        {
            return m * 1609344;
        }
        public double MilesToInches(double m)
        {
            return m * 63360;
        }
        public double MilesToFeet(double m)
        {
            return m / 12;
        }
        //Hàm chuyển đổi từ Feet
        public double FeetToKilometers(double m)
        {
            return m * 0.0003048;
        }
        public double FeetToMeters(double m)
        {
            return m * 0.3048;
        }
        public double FeetToCentimeters(double m)
        {
            return m * 30.48;
        }
        public double FeetToMilimeters(double m)
        {
            return m * 304.8;
        }
        public double FeetToMiles(double m)
        {
            return m * 0.000189394;
        }
        public double FeetToInches(double m)
        {
            return m * 12;
        }
    }
}

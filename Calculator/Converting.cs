using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Converting
    {
        public  double CelsiusToFahrenheit(double celsius)
        {
            return Math.Round((celsius * 9 / 5) + 32,2);
        }

        // Hàm chuyển đổi từ Fahrenheit sang Celsius
        public  double FahrenheitToCelsius(double fahrenheit)
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
    }
}

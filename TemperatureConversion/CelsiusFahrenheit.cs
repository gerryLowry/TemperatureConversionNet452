using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    public class CelsiusFahrenheit
    {
        public static Double Celsius(Double fahrenheit)
        {
            return (fahrenheit - 32d) / 1.8d;
        }

        public static Double Fahrenheit(Double celsius)
        {
            return (celsius * 1.8d) + 32d;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DegreeConverter
    {
        public double ToFahrenhiet(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        public double ToCelcius(double fahrenhiet)
        {
            return (32 * fahrenhiet - 32) * 5 / 9;
        }

        public int Add(int a, int b) {
            return a + b;
        }

        public int Subtract(int c , int d)
        {
            return c - d;   
        }

        public int Multiply(int e, int f) { 
           return e * f;
        }
        public double Divide(int g , int h)
        {
            return g / h;   
        }
    }
}


//if (!port.StartsWith("COM"))
//{
//    throw new FormatException("port is not in correct format");
//} else
//{
//    const int lastIndexOfPrefix = 3;
//    string portNumber = port.Substring(0, lastIndexOfPrefix);
//    return int.Parse(portNumber);   
//}

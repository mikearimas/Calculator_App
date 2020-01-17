using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculations
    {
        public static double Addition(double num, double num2)
        {
            return num + num2;
        }
        public static double Subtraction(double num, double num2)
        {
            return num - num2;
        }

        public static double Division(double num, double num2)
        {
            return (num2 != 0) ? num / num2 : 0;
        }

        public static double Multiplication(double num,double num2)
        {
            return (num2 != 0) ? num * num2 : 0;
        }
    }
}


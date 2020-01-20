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

        public static double Equals(double num, double num2, string expression)
        {
            switch (expression)
            {
                case "addition":
                    return Addition(num, num2);
                case "subtraction":
                    return Subtraction(num, num2);
                case "multiplication":
                    return Multiplication(num, num2);
                case "division":
                    return Division(num, num2);
            }
            return 0;
        }
    }
}


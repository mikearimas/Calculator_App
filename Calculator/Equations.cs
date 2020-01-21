using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Equations
    {
        private static string _expression;
        private static string _queueExpression;
        public static string Builder(string firstNum, string secondNum, string expression)
        {
            _expression = expression;
            switch (expression)
            {
                case "addition":
                    return Calculations.Addition(num: Convert.ToDouble(firstNum), num2: Convert.ToDouble(secondNum)).ToString();
                case "subtraction":
                    return Calculations.Subtraction(num: Convert.ToDouble(firstNum), num2: Convert.ToDouble(secondNum)).ToString();
                case "multiplication":
                    return Calculations.Multiplication(num: Convert.ToDouble(firstNum), num2: Convert.ToDouble(secondNum)).ToString();
                case "division":
                    return Calculations.Division(num: Convert.ToDouble(firstNum), num2: Convert.ToDouble(secondNum)).ToString();

            }


            return "Null";
        }
        public static string Builder(string firstNum, string expression)
        {
            _expression = expression;
            switch (expression)
            {
                case "addition":
                    return (firstNum + " + ");
                case "subtraction":
                    return (firstNum + " - ");
                case "multiplication":
                    return (firstNum + " * ");
                case "division":
                    return (firstNum + " ÷ ");


            }
            return "Null";
        }

        public static string HistoryBuilder(string firstNum, string secondNum, string expression)
        {
            _expression = expression;
            switch (expression)
            {
                case "addition":
                    return (firstNum + " + " + secondNum + " = ");
                case "subtraction":
                    return (firstNum + " - " + secondNum + " = ");
                case "multiplication":
                    return (firstNum + " * " + secondNum + " = ");
                case "division":
                    return (firstNum + " ÷ " + secondNum + " = ");


            }
            return "Null";
        }

        public static string GetQueueExpression()
        {
            return _queueExpression;
        }

        public static void SetExpression(string expression)
        {
            _queueExpression = expression;
        }

        public static string GetExpression()
        {
            return _expression;
        }
    }
}

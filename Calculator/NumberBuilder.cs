using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NumberBuilder
    {
        public double createdNumber { get; set; }
        public string createdNumAsString { get; set; }
        public static double CreateInput(string userInput)
        {
           
            return Convert.ToDouble(userInput);
        }
    }
}

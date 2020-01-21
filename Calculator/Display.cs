using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{ 
    class Display
    {
        public string CurrentDisplay { get; set; }
        private static string _currentDisplay = "";
        public static string Builder(string curDisplay, string newInput)
        {
            curDisplay = (curDisplay == "0") ? curDisplay = newInput : curDisplay += newInput;
            _currentDisplay = curDisplay;
            return curDisplay;
        }

        public string Refresh()
        {
            return _currentDisplay;
            
        }
        public void ClearDisplay()
        {
            _currentDisplay = "";
        }
    }
}

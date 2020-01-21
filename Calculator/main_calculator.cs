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
    public partial class main_calculator : Form
    {
        string mainDisplay = "0";
        string firstNum = "";
        string secondNum = "";
        //bool numSaved = false;
        bool expressionQueue = false;
        Display Display = new Display();

        public main_calculator()
        {
            InitializeComponent();
        }

        private void main_calculator_Load(object sender, EventArgs e)
        {
            txtBox_Equation.Text = mainDisplay;
        }

        private void btn_One_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("1");
        }

        private void btn_Two_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("2");
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("3");
        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("4");
        }

        private void btn_Five_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("5");
        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("6");
        }

        private void btn_Seven_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("7");
        }

        private void btn_Eight_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("8");
        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("9");
        }
        private void btn_zero_Click(object sender, EventArgs e)
        {
            NumberButtonHandler("0");
        }

        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            if (!mainDisplay.Contains(".") && !ValidateStr(mainDisplay))
            {
                Display.Builder(curDisplay: mainDisplay, newInput: ".");
                txtBox_Equation.Text = mainDisplay = Display.Refresh();
            } else if (!mainDisplay.Contains("."))
            {
                Display.Builder(curDisplay: mainDisplay, newInput: "0.");
                txtBox_Equation.Text = mainDisplay = Display.Refresh();
            }
        }

        private void btn_SignChange_Click(object sender, EventArgs e)
        {
                if (!ValidateStr(txtBox_Equation.Text)) {
                Display.SignChange(curDisplay: txtBox_Equation.Text);
                txtBox_Equation.Text = mainDisplay = Display.Refresh();
            }
        }
        private void btn_Addition_Click(object sender, EventArgs e)
        {
            EquationButtonHandler("addition");
        }

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {
            EquationButtonHandler("subtraction");
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            EquationButtonHandler("multiplication");
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            EquationButtonHandler("division");
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
        
        string lastExpression = expressionQueue == true ? Equations.GetQueueExpression() : Equations.GetExpression();


            if (!ValidateStr(firstNum) && ValidateStr(secondNum)) secondNum = mainDisplay;
            if (ValidateStr(firstNum)) firstNum = mainDisplay;

            if (!ValidateStr(firstNum) && !ValidateStr(secondNum) && !ValidateStr(lastExpression))
            {
                switch (lastExpression)
                {
                    case "addition":
                        if (!ValidateStr(mainDisplay)) secondNum = mainDisplay;
                        UpdateTextBoxes(firstNum, secondNum, "addition");
                        break;
                    case "subtraction":
                        if (!ValidateStr(mainDisplay)) secondNum = mainDisplay;
                        UpdateTextBoxes(firstNum, secondNum, "subtraction");
                        break;
                    case "multiplication":
                        if (!ValidateStr(mainDisplay)) secondNum = mainDisplay;
                        UpdateTextBoxes(firstNum, secondNum, "multiplication");
                        break;
                    case "division":
                        if (!ValidateStr(mainDisplay)) secondNum = mainDisplay;
                        UpdateTextBoxes(firstNum, secondNum, "division");
                        break;
                }
            }
            else if (!string.IsNullOrEmpty(firstNum) && string.IsNullOrEmpty(secondNum))
            {
                txtBox_History.Text = firstNum + " = ";
            }

        }

        private void btn_ClearEntry_Click(object sender, EventArgs e)
        {
            ClearCurrentEntry();
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtBox_Equation.Text = mainDisplay = "0";
            txtBox_History.Text = "";
            firstNum = "";
            secondNum = "";
            //numSaved = false;
            Display.ClearDisplay();
        }
        private void ClearCurrentEntry()
        {
            txtBox_Equation.Text = mainDisplay = "0";
        }

        private bool ValidateStr(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        private void EquationButtonHandler(string expression)
        {
          
            if (!ValidateStr(mainDisplay) && !ValidateStr(secondNum))
            {
                if (expressionQueue == false)
                {
                    secondNum = mainDisplay;
                    UpdateTextBoxes(firstNum, secondNum, expression);
                }
                else
                {
                    string temp = expression;
                    expression = Equations.GetQueueExpression();
                    secondNum = mainDisplay;
                    UpdateTextBoxes(firstNum, secondNum, expression);
                    Equations.SetExpression(temp);
                    //expressionQueue = false;
                }
            }
            else if (!ValidateStr(mainDisplay) && ValidateStr(secondNum)) 
            {
                firstNum = mainDisplay;
                txtBox_History.Text = Equations.Builder(firstNum, expression);
                if (ValidateStr(secondNum)) secondNum = mainDisplay;
                mainDisplay = "";
                Equations.SetExpression(expression);
                expressionQueue = true;

            }
            else if (ValidateStr(mainDisplay))
            {
                Equations.SetExpression(expression);
                expressionQueue = true;
            }

            //if (numSaved == false)
            //{
            //    if (ValidateStr(firstNum)) firstNum = mainDisplay;
            //    txtBox_History.Text = Equations.Builder(firstNum, expression);
            //    numSaved = true;
            //    mainDisplay = "";

            //}
            //else
            //{
            //    if (!ValidateStr(mainDisplay))
            //    {
            //        secondNum = mainDisplay;
            //        txtBox_History.Text = Equations.HistoryBuilder(firstNum, secondNum, expression);
            //        firstNum = txtBox_Equation.Text = Equations.Builder(firstNum, secondNum, expression);
            //        mainDisplay = "";

            //    }

            //}
        }

        private void UpdateTextBoxes(string _firstNum,string _secondNum, string _expression)
        {
            txtBox_History.Text = Equations.HistoryBuilder(_firstNum, _secondNum, _expression);
            firstNum = txtBox_Equation.Text = Equations.Builder(_firstNum, _secondNum, _expression);
            mainDisplay = "";
        }


        private void NumberButtonHandler(string numPressed)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: numPressed);
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }


    }
}

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
        bool numSaved = false;
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
            Display.Builder(curDisplay: mainDisplay, newInput: "1");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Two_Click(object sender, EventArgs e)
        {

            Display.Builder(curDisplay: mainDisplay, newInput: "2");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();
            
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: "3");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: "4");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Five_Click(object sender, EventArgs e)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: "5");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: "6");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Seven_Click(object sender, EventArgs e)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: "7");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Eight_Click(object sender, EventArgs e)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: "8");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            Display.Builder(curDisplay: mainDisplay, newInput: "9");
            txtBox_Equation.Text = mainDisplay = Display.Refresh();

        }

        private void btn_Addition_Click(object sender, EventArgs e)
        {
            if (numSaved == false)
            {
                firstNum = mainDisplay;
                txtBox_History.Text = Equations.Builder(firstNum, "addition");
                numSaved = true;
                mainDisplay = "";
                
            } else
            {
                secondNum = mainDisplay;
                txtBox_Equation.Text = Equations.Builder(firstNum, secondNum, "addition");
                txtBox_History.Text = Equations.HistoryBuilder(firstNum, secondNum, "addition");
                firstNum = secondNum;
                mainDisplay = "";

            }

        }

    }
}

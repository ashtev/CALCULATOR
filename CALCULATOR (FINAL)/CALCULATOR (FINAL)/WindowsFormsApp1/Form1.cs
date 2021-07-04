using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SciCalc calculator;
        
        public Form1()
        {
            InitializeComponent();
            // Create an instance of the SciCalc class
            calculator = new SciCalc(ref screenlabel, ref SCREEN);
        }

        // NUMBER BUTTONS

        private void btn0_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Zero);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.One);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Two);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Three);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Four);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Five);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Six);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Seven);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Eight);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calculator.InputNumber(Calculator.NumberButtons.Nine);
        }


        // UTILITY BUTTONS

        private void deci_Click(object sender, EventArgs e) //decimal function 
        {
            calculator.DoUtility(Calculator.UtilityButtons.Decimal);
        }

        private void percent_Click(object sender, EventArgs e)
        {
            calculator.DoUtility(Calculator.UtilityButtons.Percent);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            calculator.DoUtility(Calculator.UtilityButtons.OneDivX);
        }

        private void square_Click(object sender, EventArgs e)
        {
            calculator.DoUtility(Calculator.UtilityButtons.Square);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculator.DoUtility(Calculator.UtilityButtons.Cube);
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            calculator.DoUtility(Calculator.UtilityButtons.Invert);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            calculator.DoUtility(Calculator.UtilityButtons.PI);
        }

        // HELPER BUTTONS

        private void backspace_Click(object sender, EventArgs e)
        {
            calculator.DoHelper(Calculator.HelperButtons.Backspace);
        }

        private void C_Click(object sender, EventArgs e)
        {
            calculator.DoHelper(Calculator.HelperButtons.C);
        }
        private void CE_Click(object sender, EventArgs e)
        {
            calculator.DoHelper(Calculator.HelperButtons.CE);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            calculator.DoHelper(Calculator.HelperButtons.Equals);
        }


        // OPERATORS
        private void Add_Click(object sender, EventArgs e)
        {
            calculator.DoBasicOperation(Calculator.BasicOperations.Add);
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            calculator.DoBasicOperation(Calculator.BasicOperations.Subtract);
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            calculator.DoBasicOperation(Calculator.BasicOperations.Multiply);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            calculator.DoBasicOperation(Calculator.BasicOperations.Divide);
        }

        
        // FUNCTIONS
        private void Log_Click(object sender, EventArgs e)
        {
            calculator.DoFunction(SciCalc.Functions.Log);
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            calculator.DoFunction(SciCalc.Functions.Sin);
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            calculator.DoFunction(SciCalc.Functions.Cos);
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            calculator.DoFunction(SciCalc.Functions.Tan);
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            calculator.DoFunction(SciCalc.Functions.Sqrt);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

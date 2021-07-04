using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    abstract class Calculator
    {
        // Temporary storage for the results
        private double _results;

        // the current operation being used
        // private means only this class can access this field and no other
      
        private BasicOperations? _operation;

        // Checks if the answer was obtained (the = button was pressed)
        // assuming we haven't got the answer..
        private bool _answerObtained = false;

        // This property is where the input and symbols are displayed.
        // protected means this class and the inherited class can access this
        protected Label InputDisplay { get; set; }

        // This property is where the answer or entry is displayed.
        protected TextBox OutputDisplay { get; set; }

        // This is the enumeration of the number buttons 0-9
        public enum NumberButtons
        {
            Zero, One, Two,
            Three, Four, Five,
            Six, Seven, Eight, Nine
        }

        // basic operations
        public enum BasicOperations
        {
            Add, Subtract, Multiply, Divide
        }

        // utilities
        public enum UtilityButtons
        {
            Decimal, Percent, OneDivX, Square, Cube, Invert, PI
        }

        // helpers
        public enum HelperButtons
        {
            Backspace, CE, C, Equals
        }

        // This is for inputing numbers
        // This is a common method.
        public void InputNumber(NumberButtons number)
        {
            // Bring it back to false
            if (_answerObtained)
            {
                _answerObtained = false;
            }

            // This will append a digit into the output display
            // Casted it into integer to get the enum value
            DisplayOutput((int)number, append: true);
        }

        // Operators
        public void DoBasicOperation(BasicOperations opr)
        {
            if (_answerObtained)
            {
                _answerObtained = false;
            }

            if (OutputDisplay.Text != "")
            {
                string symbol = EvaluateOperation(opr);
                _results = double.Parse(OutputDisplay.Text);
                OutputDisplay.Text = "";
                InputDisplay.Text = _results.ToString() + " " + symbol;
            }
        }

        // This is for utility buttons such as decimal, percent, etc.
        public void DoUtility(UtilityButtons utility)
        {
            // If it's a decimal point
            switch (utility)
            {
                case UtilityButtons.Decimal:
                    {
                        // Only put the decimal point once..
                        if (!OutputDisplay.Text.Contains("."))
                            DisplayOutput('.', append: true);
                    }
                    break;
                case UtilityButtons.Percent:
                    {
                        // Only perform this when there's an input, otherwise an error will show up ;)
                        if (OutputDisplay.Text != "")
                        {
                            // Get the input
                            var input = double.Parse(OutputDisplay.Text);

                            // Do the operation and display
                            DisplayOutput(.1 * input);
                        }
                    }
                    break;
                case UtilityButtons.OneDivX:
                    {
                        // Only perform this when there's an input
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);

                            // DIVISION BY ZERO IS NOT ALLOWED :(
                            if (input == 0)
                            {
                                MessageBox.Show("Division by zero is not allowed!");
                            }
                            else
                            {
                                // Do the operation and display
                                DisplayOutput(1.0 / input);
                            }
                        }
                    }
                    break;
                case UtilityButtons.Square:
                    {
                        // Only perform this when there's an input
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);
                            DisplayOutput(Math.Pow(input, 2)); // Just use Math.Pow to raise a number
                        }
                    }
                    break;
                case UtilityButtons.Cube:
                    {
                        // Only perform this when there's an input
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);
                            DisplayOutput(Math.Pow(input, 3));
                        }
                    }
                    break;
                case UtilityButtons.Invert:
                    {
                        // Only perform this when there's an input
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);
                            DisplayOutput(-input); // just put -
                        }
                    }
                    break;
                case UtilityButtons.PI:
                    DisplayOutput(Math.PI);
                    break;
            }
        }

        // This is for helper buttons such as Backspace, C and CE
        public void DoHelper(HelperButtons helper)
        {
            switch (helper)
            {
                case HelperButtons.Backspace:
                    Backspace();
                    break;
                case HelperButtons.Equals:
                    GetAnswer();
                    break;
                case HelperButtons.CE:
                case HelperButtons.C:
                    Clear();
                    break;
            }
        }

        private void Backspace()
        {
            // Only perform this when there's an input
            if (OutputDisplay.Text != "")
            {
                var input = OutputDisplay.Text;
                DisplayOutput(input.Remove(input.Length - 1, 1));
            }
        }

        private void Clear()
        {
            _answerObtained = false;
            _results = 0;
            _operation = null;
            OutputDisplay.Clear();
            InputDisplay.Text = "";
        }

        private string EvaluateOperation(BasicOperations opr)
        {
            string symbol = "";

            switch (opr)
            {
                case BasicOperations.Add:
                    symbol = " + ";
                    break;
                case BasicOperations.Subtract:
                    symbol = " - ";
                    break;
                case BasicOperations.Multiply:
                    symbol = " * ";
                    break;
                case BasicOperations.Divide:
                    symbol = " / ";
                    break;
            }

            _operation = opr; // set the operation
            return symbol; // output the symbol
        }

        private void GetAnswer()
        {
            if (!_answerObtained)
            {
                switch (_operation)
                {
                    case BasicOperations.Add:
                        DisplayOutput(_results + double.Parse(OutputDisplay.Text));
                        InputDisplay.Text = "";
                        break;
                    case BasicOperations.Subtract:
                        DisplayOutput(_results - double.Parse(OutputDisplay.Text));
                        InputDisplay.Text = "";
                        break;
                    case BasicOperations.Multiply:
                        DisplayOutput(_results * double.Parse(OutputDisplay.Text));
                        InputDisplay.Text = "";
                        break;
                    case BasicOperations.Divide:
                        {
                            double input = double.Parse(OutputDisplay.Text);

                            if (input == 0)
                            {
                                MessageBox.Show("Division by zero is not allowed!");
                                OutputDisplay.Clear();
                                break;
                            }
                            else
                            {
                                DisplayOutput(_results / double.Parse(OutputDisplay.Text));
                                InputDisplay.Text = "";
                            }
                        }
                        break;
                }

                _answerObtained = true; // and the answer is obtained
            }
        }

        /*
         * Displays the either the input values
         * Info: the number or symbol to be displayed
         * Append: tells whether to append the entry after the existing entry displayed (default: false)
        */
        protected void DisplayInput(object info, bool append = false) {
            // NOTE: a += b is equivalent to a = a + b
            if (append) InputDisplay.Text += info.ToString();
            else InputDisplay.Text = info.ToString();
        }

        /*
         * Displays the either the output values
         * Info: the number or symbol to be displayed
         * Append: tells whether to append the entry after the existing entry displayed (default: false)
        */
        protected void DisplayOutput(object info, bool append = false)
        {
            if (append) OutputDisplay.Text += info.ToString();
            else OutputDisplay.Text = info.ToString();
        }
    }

    // This SciCalc class inherits from the Calculator class
    // this is just an extension of the Calculator class which demonstrates inheritance.
    class SciCalc : Calculator
    {
        public enum Functions
        {
            Log, Sin, Cos, Tan, Sqrt
        }

        // The class constructor
        // the parameters are passed by reference
        public SciCalc(ref Label inDisp, ref TextBox outDisp)
        {
            InputDisplay = inDisp;
            OutputDisplay = outDisp;
        }

        public void DoFunction(Functions button)
        {
            if (OutputDisplay.Text != "")
            {
                double input = double.Parse(OutputDisplay.Text);

                switch (button)
                {
                    case Functions.Log:
                        DisplayOutput(Math.Log10(input));
                        DisplayInput("log(" + input + ")");
                        break;
                    case Functions.Sin:
                        DisplayOutput(Math.Sin(input));
                        DisplayInput("sin(" + input + ")");
                        break;
                    case Functions.Cos:
                        DisplayOutput(Math.Cos(input));
                        DisplayInput("cos(" + input + ")");
                        break;
                    case Functions.Tan:
                        DisplayOutput(Math.Tan(input));
                        DisplayInput("tan(" + input + ")");
                        break;
                    case Functions.Sqrt:
                        DisplayOutput(Math.Sqrt(input));
                        DisplayInput("√" + input + "");
                        break;
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    abstract class Calculator
    {
       
        private double _results;
        private BasicOperations? _operation;
        private bool _answerObtained = false;
        protected Label InputDisplay { get; set; }
        protected TextBox OutputDisplay { get; set; }


        public enum NumberButtons
        {
            Zero, One, Two,
            Three, Four, Five,
            Six, Seven, Eight, Nine
        }

        public enum BasicOperations
        {
            Add, Subtract, Multiply, Divide
        }

        public enum UtilityButtons
        {
            Decimal, Percent, OneDivX, Square, Cube, Invert, PI
        }


        public enum HelperButtons
        {
            Backspace, CE, C, Equals
        }

  
        public void InputNumber(NumberButtons number)
        {
            if (_answerObtained)
            {
                _answerObtained = false;
            }

            DisplayOutput((int)number, append: true);
        }

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

        public void DoUtility(UtilityButtons utility)
        {
            switch (utility)
            {
                case UtilityButtons.Decimal:
                    {
                        if (!OutputDisplay.Text.Contains("."))
                            DisplayOutput('.', append: true);
                    }
                    break;
                case UtilityButtons.Percent:
                    {
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);

                            DisplayOutput(.1 * input);
                        }
                    }
                    break;
                case UtilityButtons.OneDivX:
                    {
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);

                            if (input == 0)
                            {
                                MessageBox.Show("Division by zero is not allowed!");
                            }
                            else
                            {
                                DisplayOutput(1.0 / input);
                            }
                        }
                    }
                    break;
                case UtilityButtons.Square:
                    {
                        
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);
                            DisplayOutput(Math.Pow(input, 2)); 
                        }
                    }
                    break;
                case UtilityButtons.Cube:
                    {
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);
                            DisplayOutput(Math.Pow(input, 3));
                        }
                    }
                    break;
                case UtilityButtons.Invert:
                    {
                        if (OutputDisplay.Text != "")
                        {
                            var input = double.Parse(OutputDisplay.Text);
                            DisplayOutput(-input); 
                        }
                    }
                    break;
                case UtilityButtons.PI:
                    DisplayOutput(Math.PI);
                    break;
            }
        }

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

            _operation = opr; 
            return symbol; 
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

                _answerObtained = true; 
            }
        }

        
        protected void DisplayInput(object info, bool append = false) {
            if (append) InputDisplay.Text += info.ToString();
            else InputDisplay.Text = info.ToString();
        }

       
        protected void DisplayOutput(object info, bool append = false)
        {
            if (append) OutputDisplay.Text += info.ToString();
            else OutputDisplay.Text = info.ToString();
        }
    }

    class SciCalc : Calculator
    {
        public enum Functions
        {
            Log, Sin, Cos, Tan, Sqrt
        }

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

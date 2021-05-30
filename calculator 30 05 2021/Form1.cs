using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCUAPP
{
    public partial class Form1 : Form
    {

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "1";
            calcuDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "2";
            calcuDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "3";
            calcuDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "4";
            calcuDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "5";
            calcuDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "6";
            calcuDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "7";
            calcuDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "8";
            calcuDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "9";
            calcuDisplay.Text += userInput;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calcuDisplay.Text = "0";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //plus
            if(function == '+')
            {
                result = firstNum + secondNum;
                calcuDisplay.Text = result.ToString();
            }

            //minus
            else if(function == '-')
            {

                result = firstNum - secondNum;
                calcuDisplay.Text = result.ToString();
            }

            //div
            else if (function == '/')
            {
                if(secondNum == '0')
                {
                    calcuDisplay.Text = "UNDEFINED";
                }
                else
                {
                    result = firstNum / secondNum;
                    calcuDisplay.Text = result.ToString();
                }

            }

            //mult
            else if(function == '*')
            {
                result = firstNum * secondNum;
                calcuDisplay.Text = result.ToString();
            }
        }

        private void deciButton_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text += ".";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = "";
            userInput += "0";
            calcuDisplay.Text += userInput;
        }
    }
}

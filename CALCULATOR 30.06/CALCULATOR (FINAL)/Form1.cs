using System;
using System.Windows.Forms;

namespace CALCULATOR__FINAL_
{
    public partial class Form1 : Form
    {
        Double results = 0; //To store numerical intputs
        String operation = ""; // an empty string to use in operations 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Backspace button 
        private void backspace_Click(object sender, EventArgs e)
        {
            if (SCREEN.Text.Length > 0)
            {
                SCREEN.Text = SCREEN.Text.Remove(SCREEN.Text.Length - 1, 1);
            }

            if (SCREEN.Text == "")
            {
                SCREEN.Text = "";

            }
        }
        private void plusminus_Click(object sender, EventArgs e)
        {
            SCREEN.Text = (-1 * Double.Parse(SCREEN.Text)).ToString();
        }

        //clear button
        private void C_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            screenlbl.Text = "";

        }
        //clear entry
        private void CE_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            screenlbl.Text = "";
        }
        //scientific notation
        private void button9_Click_1(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(SCREEN.Text));
            SCREEN.Text = System.Convert.ToString(a);
        }
        //convert to binary
        private void button10_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a, 2);
        }
        //Cos Function
        private void button11_Click_1(object sender, EventArgs e)
        {
            double Cos = Double.Parse(SCREEN.Text);
            Cos = Math.Cos(Cos);
            SCREEN.Text = System.Convert.ToString(Cos);
            screenlabel.Text = System.Convert.ToString("cos" + "(" + (SCREEN.Text) + ")");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void screenlbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void square_Click(object sender, EventArgs e)
        //square
        {
            Double a;
            a = Convert.ToDouble(SCREEN.Text) * Convert.ToDouble(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a);
        }
        //Basic arithmetic operations (plus, minus, divide, multiply)
        private void equals_Click(object sender, EventArgs e)
        {
            screenlabel.Text = "";
            switch (operation)
            {
                case "+":
                    SCREEN.Text = (results + Double.Parse(SCREEN.Text)).ToString();
                    break;
                case "-":
                    SCREEN.Text = (results - Double.Parse(SCREEN.Text)).ToString();
                    break;
                case "/":
                    SCREEN.Text = (results / Double.Parse(SCREEN.Text)).ToString();
                    break;
                case "*":
                    SCREEN.Text = (results * Double.Parse(SCREEN.Text)).ToString();
                    break;
               

            }
        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void an(object sender, EventArgs e)
        {

        }

        private void OPERATIONS(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(SCREEN.Text);
            SCREEN.Text = "";
            screenlabel.Text = System.Convert.ToString(results) + " " + operation;
        }
        //Pi value
        private void pi_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "3.14159265359";
        }
        //Log Function
        private void Log_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(SCREEN.Text);
            log = Math.Log10(log);
            SCREEN.Text = System.Convert.ToString(log);
            screenlabel.Text = System.Convert.ToString("log" + "(" + (SCREEN.Text) + ")");
        }
        //Squareroot function
        private void Sqrt_Click(object sender, EventArgs e)
        {
            double SR = Double.Parse(SCREEN.Text);
            SR = Math.Sqrt(SR);
            SCREEN.Text = System.Convert.ToString(SR);
            screenlabel.Text = System.Convert.ToString("√" + SCREEN.Text);

        }
        
        //Sin Function
        private void Sin_Click(object sender, EventArgs e)
        {
            double Sin = Double.Parse(SCREEN.Text);
            Sin = Math.Sin(Sin);
            SCREEN.Text = System.Convert.ToString(Sin);
            screenlabel.Text = System.Convert.ToString("sin" + "(" + (SCREEN.Text) + ")");
        }
        
        //tan function
        private void Tan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(SCREEN.Text);
            tan = Math.Tan(tan);
            SCREEN.Text = System.Convert.ToString(tan);
            screenlabel.Text = System.Convert.ToString("tan" + "(" + (SCREEN.Text) + ")");
        }
        
        //Cube
        private void button5_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(SCREEN.Text) * Convert.ToDouble(SCREEN.Text) * Convert.ToDouble(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a);
        }
       
        //Percent
        private void percent_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(SCREEN.Text) / Convert.ToDouble(100);
            SCREEN.Text = System.Convert.ToString(a);
        }
        //start of number buttons
        private void btn7_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "7";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SCREEN.Text = SCREEN.Text + "8";
        }
        //end of number buttons
        private void deci_Click(object sender, EventArgs e) //decimal function 
        {
            if (!SCREEN.Text.Contains("."))
            {
                SCREEN.Text = SCREEN.Text + deci.Text;
                screenlabel.Text = SCREEN.Text;
            }
            else if (SCREEN.Text.Contains("."))
            {
                SCREEN.Text = SCREEN.Text;
                screenlabel.Text = SCREEN.Text;


            }
        }
    }
}

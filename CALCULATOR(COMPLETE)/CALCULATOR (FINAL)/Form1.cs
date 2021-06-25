using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR__FINAL_
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

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

        private void backspace_Click(object sender, EventArgs e)
        {
            if (SCREEN.Text.Length > 0)
            {
                SCREEN.Text = SCREEN.Text.Remove(SCREEN.Text.Length - 1, 1);
            }

            if (SCREEN.Text == "")
            {
                SCREEN.Text = "0";

            }
        }
        private void plusminus_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "0";
            screenlbl.Text = "";

        }

        private void CE_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "0";
            screenlbl.Text = "";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(SCREEN.Text));
            SCREEN.Text = System.Convert.ToString(a);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a, 2);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            double Cos = Double.Parse(SCREEN.Text);
            Cos = Math.Cos(Cos);
            SCREEN.Text = System.Convert.ToString(Cos);
            screenlabel.Text = System.Convert.ToString("cos" + "(" + (SCREEN.Text) + ")");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            double cosh = Double.Parse(SCREEN.Text);
            cosh = Math.Cosh(cosh);
            SCREEN.Text = System.Convert.ToString(cosh);
            screenlabel.Text = System.Convert.ToString("cosh" + "(" + (SCREEN.Text) + ")");
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
        {
            Double a;
            a = Convert.ToDouble(SCREEN.Text) * Convert.ToDouble(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a);
        }

        private void BTNCLICK(object sender, EventArgs e)
        {
            if ((SCREEN.Text == "0") || (enter_value))
                SCREEN.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!SCREEN.Text.Contains("."))
                    SCREEN.Text = SCREEN.Text + num.Text;
            }
            else
                SCREEN.Text = SCREEN.Text + num.Text;
        }

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
                case "Mod":
                    SCREEN.Text = (results % Double.Parse(SCREEN.Text)).ToString();
                    break;
                case "Exp":
                    double b = Double.Parse(SCREEN.Text);
                    double a;
                    a = (results);
                    SCREEN.Text = Math.Exp(b * Math.Log(a * 4)).ToString();
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

        private void pi_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "3.14159265359";

        }

        private void Log_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(SCREEN.Text);
            log = Math.Log10(log);
            SCREEN.Text = System.Convert.ToString(log);
            screenlabel.Text = System.Convert.ToString("log" + "(" + (SCREEN.Text) + ")");
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            double SR = Double.Parse(SCREEN.Text);
            SR = Math.Sqrt(SR);
            SCREEN.Text = System.Convert.ToString(SR);
            screenlabel.Text = System.Convert.ToString("√" + "(" + (SCREEN.Text) + ")");

        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            double Sinh = Double.Parse(SCREEN.Text);
            Sinh = Math.Sinh(Sinh);
            SCREEN.Text = System.Convert.ToString(Sinh);
            screenlabel.Text = System.Convert.ToString("sinh" + "(" + (SCREEN.Text) + ")");
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double Sin = Double.Parse(SCREEN.Text);
            Sin = Math.Sin(Sin);
            SCREEN.Text = System.Convert.ToString(Sin);
            screenlabel.Text = System.Convert.ToString("sin" + "(" + (SCREEN.Text) + ")");
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(SCREEN.Text);
            tanh = Math.Tanh(tanh);
            SCREEN.Text = System.Convert.ToString(tanh);
            screenlabel.Text = System.Convert.ToString("tanh" + "(" + (SCREEN.Text) + ")");
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(SCREEN.Text);
            tan = Math.Tan(tan);
            SCREEN.Text = System.Convert.ToString(tan);
            screenlabel.Text = System.Convert.ToString("tan" + "(" + (SCREEN.Text) + ")");
        }

        private void Hex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a, 16);

        }

        private void oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a, 8);
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(SCREEN.Text) * Convert.ToDouble(SCREEN.Text) * Convert.ToDouble(SCREEN.Text);
            SCREEN.Text = System.Convert.ToString(a);
        }

        private void lnx_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(SCREEN.Text);
            log = Math.Log(log);
            SCREEN.Text = System.Convert.ToString(log);
            screenlabel.Text = System.Convert.ToString("log" + "(" + (SCREEN.Text) + ")");
        }

        private void percent_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(SCREEN.Text) / Convert.ToDouble(100);
            SCREEN.Text = System.Convert.ToString(a);
        }
    }
}

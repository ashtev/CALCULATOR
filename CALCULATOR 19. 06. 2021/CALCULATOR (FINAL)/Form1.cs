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

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

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
    }
}

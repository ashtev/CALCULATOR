using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_03052021
{
    public partial class Form1 : Form
    {
        string one = "";
        string two = "";
        char function;
        double result = 0.0;
        string input = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "4";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            function = '=';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void SCREEN_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "6";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "5";

        }

        private void AC_Click(object sender, EventArgs e)
        {
            function = 'c';
        }

        private void ONE_Click(object sender, EventArgs e)
        {

            SCREEN.Text = "";
            input += "1";
            SCREEN.Text += "input";
        }

        private void TWO_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "2";

        }

        private void THREE_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "3";

        }

        private void SEVEN_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "7";

        }

        private void EIGHT_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "8";

        }

        private void NINE_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "9";

        }

        private void ZERO_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += "0";

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void add_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void DECIMAL_Click(object sender, EventArgs e)
        {
            SCREEN.Text = "";
            SCREEN.Text += ".";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plusminus_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}

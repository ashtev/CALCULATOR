
namespace CALCULATOR__FINAL_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SCREEN = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Sinh = new System.Windows.Forms.Button();
            this.onedivx = new System.Windows.Forms.Button();
            this.bin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.cosh = new System.Windows.Forms.Button();
            this.lnx = new System.Windows.Forms.Button();
            this.Hex = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.tanh = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.oct = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.screenlabel = new System.Windows.Forms.Label();
            this.screenlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SCREEN
            // 
            this.SCREEN.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SCREEN.Location = new System.Drawing.Point(16, 23);
            this.SCREEN.Multiline = true;
            this.SCREEN.Name = "SCREEN";
            this.SCREEN.Size = new System.Drawing.Size(433, 50);
            this.SCREEN.TabIndex = 2;
            this.SCREEN.Text = "0";
            this.SCREEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SCREEN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.add.ForeColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(178, 127);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(48, 42);
            this.add.TabIndex = 9;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.OPERATIONS);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.Control;
            this.btn9.Location = new System.Drawing.Point(124, 127);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 42);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(70, 127);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 42);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(16, 127);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 42);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtract.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.subtract.ForeColor = System.Drawing.SystemColors.Control;
            this.subtract.Location = new System.Drawing.Point(178, 175);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(48, 42);
            this.subtract.TabIndex = 13;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.OPERATIONS);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(124, 175);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 42);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(70, 175);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 42);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(16, 175);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 42);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.multiply.ForeColor = System.Drawing.SystemColors.Control;
            this.multiply.Location = new System.Drawing.Point(178, 223);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(48, 42);
            this.multiply.TabIndex = 17;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.OPERATIONS);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(124, 223);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 42);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(70, 223);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 42);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(16, 223);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 42);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.divide.ForeColor = System.Drawing.SystemColors.Control;
            this.divide.Location = new System.Drawing.Point(178, 271);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(48, 42);
            this.divide.TabIndex = 21;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.OPERATIONS);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equals.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.equals.ForeColor = System.Drawing.SystemColors.Control;
            this.equals.Location = new System.Drawing.Point(124, 271);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(48, 42);
            this.equals.TabIndex = 20;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // deci
            // 
            this.deci.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deci.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deci.ForeColor = System.Drawing.SystemColors.Control;
            this.deci.Location = new System.Drawing.Point(70, 271);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(48, 42);
            this.deci.TabIndex = 19;
            this.deci.Text = ".";
            this.deci.UseVisualStyleBackColor = false;
            this.deci.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.Control;
            this.btn0.Location = new System.Drawing.Point(16, 271);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 42);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.BTNCLICK);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backspace.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.backspace.ForeColor = System.Drawing.SystemColors.Control;
            this.backspace.Location = new System.Drawing.Point(16, 79);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(48, 42);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CE.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CE.ForeColor = System.Drawing.SystemColors.Control;
            this.CE.Location = new System.Drawing.Point(70, 79);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(48, 42);
            this.CE.TabIndex = 3;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.C.ForeColor = System.Drawing.SystemColors.Control;
            this.C.Location = new System.Drawing.Point(124, 79);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(48, 42);
            this.C.TabIndex = 4;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // plusminus
            // 
            this.plusminus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plusminus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusminus.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.plusminus.ForeColor = System.Drawing.SystemColors.Control;
            this.plusminus.Location = new System.Drawing.Point(178, 79);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(48, 42);
            this.plusminus.TabIndex = 5;
            this.plusminus.Text = "±";
            this.plusminus.UseVisualStyleBackColor = false;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.square.ForeColor = System.Drawing.SystemColors.Control;
            this.square.Location = new System.Drawing.Point(401, 79);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(48, 42);
            this.square.TabIndex = 25;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sqrt.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Sqrt.ForeColor = System.Drawing.SystemColors.Control;
            this.Sqrt.Location = new System.Drawing.Point(347, 79);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(48, 42);
            this.Sqrt.TabIndex = 24;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = false;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Log.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Log.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Log.ForeColor = System.Drawing.SystemColors.Control;
            this.Log.Location = new System.Drawing.Point(293, 79);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(48, 42);
            this.Log.TabIndex = 23;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = false;
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pi.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.pi.ForeColor = System.Drawing.SystemColors.Control;
            this.pi.Location = new System.Drawing.Point(239, 79);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(48, 42);
            this.pi.TabIndex = 22;
            this.pi.Text = "π";
            this.pi.UseVisualStyleBackColor = false;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(401, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 42);
            this.button5.TabIndex = 29;
            this.button5.Tag = "cube";
            this.button5.Text = "x^3";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dec.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Dec.ForeColor = System.Drawing.SystemColors.Control;
            this.Dec.Location = new System.Drawing.Point(347, 127);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(48, 42);
            this.Dec.TabIndex = 28;
            this.Dec.Text = "Dec";
            this.Dec.UseVisualStyleBackColor = false;
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sin.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Sin.ForeColor = System.Drawing.SystemColors.Control;
            this.Sin.Location = new System.Drawing.Point(293, 127);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(48, 42);
            this.Sin.TabIndex = 27;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = false;
            // 
            // Sinh
            // 
            this.Sinh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sinh.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Sinh.ForeColor = System.Drawing.SystemColors.Control;
            this.Sinh.Location = new System.Drawing.Point(239, 127);
            this.Sinh.Name = "Sinh";
            this.Sinh.Size = new System.Drawing.Size(48, 42);
            this.Sinh.TabIndex = 26;
            this.Sinh.Text = "Sinh";
            this.Sinh.UseVisualStyleBackColor = false;
            // 
            // onedivx
            // 
            this.onedivx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.onedivx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.onedivx.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.onedivx.ForeColor = System.Drawing.SystemColors.Control;
            this.onedivx.Location = new System.Drawing.Point(401, 175);
            this.onedivx.Name = "onedivx";
            this.onedivx.Size = new System.Drawing.Size(48, 42);
            this.onedivx.TabIndex = 33;
            this.onedivx.Text = "1/x";
            this.onedivx.UseVisualStyleBackColor = false;
            this.onedivx.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // bin
            // 
            this.bin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bin.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bin.ForeColor = System.Drawing.SystemColors.Control;
            this.bin.Location = new System.Drawing.Point(347, 175);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(48, 42);
            this.bin.TabIndex = 32;
            this.bin.Text = "Bin";
            this.bin.UseVisualStyleBackColor = false;
            this.bin.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cos.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cos.ForeColor = System.Drawing.SystemColors.Control;
            this.cos.Location = new System.Drawing.Point(293, 175);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(48, 42);
            this.cos.TabIndex = 31;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // cosh
            // 
            this.cosh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cosh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cosh.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cosh.ForeColor = System.Drawing.SystemColors.Control;
            this.cosh.Location = new System.Drawing.Point(239, 175);
            this.cosh.Name = "cosh";
            this.cosh.Size = new System.Drawing.Size(48, 42);
            this.cosh.TabIndex = 30;
            this.cosh.Text = "Cosh";
            this.cosh.UseVisualStyleBackColor = false;
            this.cosh.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // lnx
            // 
            this.lnx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lnx.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lnx.ForeColor = System.Drawing.SystemColors.Control;
            this.lnx.Location = new System.Drawing.Point(401, 223);
            this.lnx.Name = "lnx";
            this.lnx.Size = new System.Drawing.Size(48, 42);
            this.lnx.TabIndex = 37;
            this.lnx.Text = "ln x";
            this.lnx.UseVisualStyleBackColor = false;
            // 
            // Hex
            // 
            this.Hex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Hex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hex.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Hex.ForeColor = System.Drawing.SystemColors.Control;
            this.Hex.Location = new System.Drawing.Point(347, 223);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(48, 42);
            this.Hex.TabIndex = 36;
            this.Hex.Text = "Hex";
            this.Hex.UseVisualStyleBackColor = false;
            // 
            // Tan
            // 
            this.Tan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tan.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Tan.ForeColor = System.Drawing.SystemColors.Control;
            this.Tan.Location = new System.Drawing.Point(293, 223);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(48, 42);
            this.Tan.TabIndex = 35;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = false;
            // 
            // tanh
            // 
            this.tanh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tanh.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tanh.ForeColor = System.Drawing.SystemColors.Control;
            this.tanh.Location = new System.Drawing.Point(239, 223);
            this.tanh.Name = "tanh";
            this.tanh.Size = new System.Drawing.Size(48, 42);
            this.tanh.TabIndex = 34;
            this.tanh.Text = "Tanh";
            this.tanh.UseVisualStyleBackColor = false;
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.percent.ForeColor = System.Drawing.SystemColors.Control;
            this.percent.Location = new System.Drawing.Point(401, 271);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(48, 42);
            this.percent.TabIndex = 41;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            // 
            // oct
            // 
            this.oct.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oct.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.oct.ForeColor = System.Drawing.SystemColors.Control;
            this.oct.Location = new System.Drawing.Point(347, 271);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(48, 42);
            this.oct.TabIndex = 40;
            this.oct.Text = "Oct";
            this.oct.UseVisualStyleBackColor = false;
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mod.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mod.ForeColor = System.Drawing.SystemColors.Control;
            this.mod.Location = new System.Drawing.Point(293, 271);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(48, 42);
            this.mod.TabIndex = 39;
            this.mod.Text = "Mod";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.an);
            // 
            // exponent
            // 
            this.exponent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exponent.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exponent.ForeColor = System.Drawing.SystemColors.Control;
            this.exponent.Location = new System.Drawing.Point(239, 271);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(48, 42);
            this.exponent.TabIndex = 38;
            this.exponent.Text = "Exp";
            this.exponent.UseVisualStyleBackColor = false;
            this.exponent.Click += new System.EventHandler(this.an);
            // 
            // screenlabel
            // 
            this.screenlabel.AutoSize = true;
            this.screenlabel.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.screenlabel.Location = new System.Drawing.Point(22, 33);
            this.screenlabel.Name = "screenlabel";
            this.screenlabel.Size = new System.Drawing.Size(0, 34);
            this.screenlabel.TabIndex = 42;
            this.screenlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // screenlbl
            // 
            this.screenlbl.AutoSize = true;
            this.screenlbl.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.screenlbl.Location = new System.Drawing.Point(17, 42);
            this.screenlbl.Name = "screenlbl";
            this.screenlbl.Size = new System.Drawing.Size(0, 16);
            this.screenlbl.TabIndex = 43;
            this.screenlbl.Click += new System.EventHandler(this.screenlbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 333);
            this.Controls.Add(this.screenlbl);
            this.Controls.Add(this.screenlabel);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.lnx);
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.tanh);
            this.Controls.Add(this.onedivx);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.cosh);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Sinh);
            this.Controls.Add(this.square);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.add);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.SCREEN);
            this.Controls.Add(this.backspace);
            this.Name = "Form1";
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Filee;
        private System.Windows.Forms.TextBox SCREEN;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Sinh;
        private System.Windows.Forms.Button onedivx;
        private System.Windows.Forms.Button bin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button cosh;
        private System.Windows.Forms.Button lnx;
        private System.Windows.Forms.Button Hex;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button tanh;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button oct;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Label screenlabel;
        private System.Windows.Forms.Label screenlbl;
    }
}


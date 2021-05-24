
namespace TicTacToe
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
            this.Panname = new System.Windows.Forms.Panel();
            this.PanGame = new System.Windows.Forms.Panel();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.butt6 = new System.Windows.Forms.Button();
            this.butt5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.PanGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panname
            // 
            this.Panname.AccessibleDescription = "main panel";
            this.Panname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panname.Location = new System.Drawing.Point(517, 12);
            this.Panname.Name = "Panname";
            this.Panname.Size = new System.Drawing.Size(240, 52);
            this.Panname.TabIndex = 0;
            // 
            // PanGame
            // 
            this.PanGame.AccessibleDescription = "game panel";
            this.PanGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanGame.Controls.Add(this.but9);
            this.PanGame.Controls.Add(this.but8);
            this.PanGame.Controls.Add(this.but7);
            this.PanGame.Controls.Add(this.butt6);
            this.PanGame.Controls.Add(this.butt5);
            this.PanGame.Controls.Add(this.but4);
            this.PanGame.Controls.Add(this.but3);
            this.PanGame.Controls.Add(this.but2);
            this.PanGame.Controls.Add(this.but1);
            this.PanGame.Location = new System.Drawing.Point(517, 79);
            this.PanGame.Name = "PanGame";
            this.PanGame.Size = new System.Drawing.Size(240, 252);
            this.PanGame.TabIndex = 1;
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(10, 9);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(68, 58);
            this.but1.TabIndex = 0;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(84, 9);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(68, 58);
            this.but2.TabIndex = 1;
            this.but2.Text = "1";
            this.but2.UseVisualStyleBackColor = true;
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(158, 9);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(68, 58);
            this.but3.TabIndex = 2;
            this.but3.Text = "1";
            this.but3.UseVisualStyleBackColor = true;
            // 
            // butt6
            // 
            this.butt6.Location = new System.Drawing.Point(158, 73);
            this.butt6.Name = "butt6";
            this.butt6.Size = new System.Drawing.Size(68, 58);
            this.butt6.TabIndex = 5;
            this.butt6.Text = "1";
            this.butt6.UseVisualStyleBackColor = true;
            // 
            // butt5
            // 
            this.butt5.Location = new System.Drawing.Point(84, 73);
            this.butt5.Name = "butt5";
            this.butt5.Size = new System.Drawing.Size(68, 58);
            this.butt5.TabIndex = 4;
            this.butt5.Text = "1";
            this.butt5.UseVisualStyleBackColor = true;
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(10, 73);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(68, 58);
            this.but4.TabIndex = 3;
            this.but4.Text = "1";
            this.but4.UseVisualStyleBackColor = true;
            // 
            // but9
            // 
            this.but9.Location = new System.Drawing.Point(158, 137);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(68, 58);
            this.but9.TabIndex = 8;
            this.but9.Text = "1";
            this.but9.UseVisualStyleBackColor = true;
            // 
            // but8
            // 
            this.but8.Location = new System.Drawing.Point(84, 137);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(68, 58);
            this.but8.TabIndex = 7;
            this.but8.Text = "1";
            this.but8.UseVisualStyleBackColor = true;
            // 
            // but7
            // 
            this.but7.Location = new System.Drawing.Point(10, 137);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(68, 58);
            this.but7.TabIndex = 6;
            this.but7.Text = "1";
            this.but7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanGame);
            this.Controls.Add(this.Panname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panname;
        private System.Windows.Forms.Panel PanGame;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button butt6;
        private System.Windows.Forms.Button butt5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
    }
}


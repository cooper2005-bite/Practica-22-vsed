﻿namespace Practica__22_vsed
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Cooper Black", 14.25F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(304, 45);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 0;
            label1.Text = "Tabla de multiplicar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Cooper Black", 14.25F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(62, 95);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 1;
            label2.Text = "Introduce el Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Cooper Black", 14.25F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(62, 116);
            label3.Name = "label3";
            label3.Size = new Size(253, 21);
            label3.TabIndex = 2;
            label3.Text = "de la tabla de Multiplicar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Cooper Black", 14.25F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(525, 95);
            label4.Name = "label4";
            label4.Size = new Size(227, 21);
            label4.TabIndex = 3;
            label4.Text = "Limite maximo para la";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Cooper Black", 14.25F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(525, 116);
            label5.Name = "label5";
            label5.Size = new Size(204, 21);
            label5.TabIndex = 4;
            label5.Text = "tabla de multiplicar";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Black;
            listBox1.Font = new Font("Cooper Black", 14.25F);
            listBox1.ForeColor = SystemColors.ButtonHighlight;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(333, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 277);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Cooper Black", 14.25F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(547, 315);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 6;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.Font = new Font("Cooper Black", 14.25F);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(97, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.Font = new Font("Cooper Black", 14.25F);
            textBox2.ForeColor = SystemColors.ButtonFace;
            textBox2.Location = new Point(561, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDark;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}

﻿namespace Practica_15
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 36);
            label1.Name = "label1";
            label1.Size = new Size(668, 15);
            label1.TabIndex = 0;
            label1.Text = "El programa aplica un aumento del 15% si el sueldo del trabajador es inferior a 400 mil, en caso contrario el aumento es de 8%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(54, 112);
            label2.Name = "label2";
            label2.Size = new Size(155, 30);
            label2.TabIndex = 1;
            label2.Text = "Ingresar sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(54, 207);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 2;
            label3.Text = "Nuevo sueldo";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(199, 163);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 3;
            button1.Text = "Calcular ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
﻿namespace evinha
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
            buttonAbrir = new Button();
            buttonSalvar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 1);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(2, -3);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(75, 23);
            buttonAbrir.TabIndex = 1;
            buttonAbrir.Text = "Abrir";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(83, -3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(798, 427);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonAbrir);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAbrir;
        private Button buttonSalvar;
        private TextBox textBox1;
    }
}

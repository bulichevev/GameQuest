﻿namespace GameQuest
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonKnight1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(655, 79);
            this.button1.TabIndex = 10;
            this.button1.Text = "Напасть на мага";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKnight1
            // 
            this.buttonKnight1.Location = new System.Drawing.Point(61, 290);
            this.buttonKnight1.Name = "buttonKnight1";
            this.buttonKnight1.Size = new System.Drawing.Size(655, 79);
            this.buttonKnight1.TabIndex = 9;
            this.buttonKnight1.Text = "Стать Главой Черного Ордена";
            this.buttonKnight1.UseVisualStyleBackColor = true;
            this.buttonKnight1.Click += new System.EventHandler(this.buttonKnight1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Как вы поступите?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(655, 79);
            this.button2.TabIndex = 11;
            this.button2.Text = "Взять деньги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKnight1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonKnight1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
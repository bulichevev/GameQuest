namespace GameQuest
{
    partial class Form3
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
            this.buttonSecretly = new System.Windows.Forms.Button();
            this.buttonKnight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSecretly
            // 
            this.buttonSecretly.Location = new System.Drawing.Point(68, 276);
            this.buttonSecretly.Name = "buttonSecretly";
            this.buttonSecretly.Size = new System.Drawing.Size(655, 79);
            this.buttonSecretly.TabIndex = 6;
            this.buttonSecretly.Text = "К бою!";
            this.buttonSecretly.UseVisualStyleBackColor = true;
            this.buttonSecretly.Click += new System.EventHandler(this.buttonSecretly_Click);
            // 
            // buttonKnight
            // 
            this.buttonKnight.Location = new System.Drawing.Point(68, 143);
            this.buttonKnight.Name = "buttonKnight";
            this.buttonKnight.Size = new System.Drawing.Size(655, 79);
            this.buttonKnight.TabIndex = 5;
            this.buttonKnight.Text = "Отвлечь, разбив окно";
            this.buttonKnight.UseVisualStyleBackColor = true;
            this.buttonKnight.Click += new System.EventHandler(this.buttonKnight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Что делать с рыцарем?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSecretly);
            this.Controls.Add(this.buttonKnight);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSecretly;
        private System.Windows.Forms.Button buttonKnight;
        private System.Windows.Forms.Label label1;
    }
}
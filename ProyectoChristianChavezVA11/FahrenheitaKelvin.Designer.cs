namespace ProyectoChristianChavezVA11
{
    partial class FahrenheitaKelvin
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
            label5 = new Label();
            label2 = new Label();
            FAK = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 325);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 9;
            label5.Text = "Es";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 325);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Resultado:";
            // 
            // FAK
            // 
            FAK.Location = new Point(348, 221);
            FAK.Name = "FAK";
            FAK.Size = new Size(94, 29);
            FAK.TabIndex = 7;
            FAK.Text = "Convertir";
            FAK.UseVisualStyleBackColor = true;
            FAK.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 106);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 6;
            label1.Text = "Fahrenheit a Kelvin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 5;
            // 
            // FahrenheitaKelvin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(FAK);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FahrenheitaKelvin";
            Text = "FahrenheitaKelvin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label2;
        private Button FAK;
        private Label label1;
        private TextBox textBox1;
    }
}
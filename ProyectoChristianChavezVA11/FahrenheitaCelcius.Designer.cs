namespace ProyectoChristianChavezVA11
{
    partial class FahrenheitaCelcius
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
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 325);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 9;
            label3.Text = "Es";
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
            // button1
            // 
            button1.Location = new Point(348, 221);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 106);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 6;
            label1.Text = "Fahrenheit a Celcius";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 5;
            // 
            // FahrenheitaCelcius
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Name = "FahrenheitaCelcius";
            Text = "FahrenheitaCelcius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
    }
}
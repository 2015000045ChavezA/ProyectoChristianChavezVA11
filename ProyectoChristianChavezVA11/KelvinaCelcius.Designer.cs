namespace ProyectoChristianChavezVA11
{
    partial class KelvinaCelcius
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
            label4 = new Label();
            label2 = new Label();
            KAC = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 325);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 9;
            label4.Text = "Es";
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
            // KAC
            // 
            KAC.Location = new Point(348, 221);
            KAC.Name = "KAC";
            KAC.Size = new Size(94, 29);
            KAC.TabIndex = 7;
            KAC.Text = "Convertir";
            KAC.UseVisualStyleBackColor = true;
            KAC.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 106);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 6;
            label1.Text = "Kelvin a Celcius";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 5;
            // 
            // KelvinaCelcius
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(KAC);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "KelvinaCelcius";
            Text = "KelvinaCelcius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Button KAC;
        private Label label1;
        private TextBox textBox1;
    }
}
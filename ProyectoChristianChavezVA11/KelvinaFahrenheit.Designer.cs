namespace ProyectoChristianChavezVA11
{
    partial class KelvinaFahrenheit
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
            label6 = new Label();
            label2 = new Label();
            BNT = new Button();
            label1 = new Label();
            KAF = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 325);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 9;
            label6.Text = "Es";
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
            // BNT
            // 
            BNT.Location = new Point(348, 221);
            BNT.Name = "BNT";
            BNT.Size = new Size(94, 29);
            BNT.TabIndex = 7;
            BNT.Text = "Convertir";
            BNT.UseVisualStyleBackColor = true;
            BNT.Click += KAF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 106);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 6;
            label1.Text = "Kelvin a Fahrenheit";
            // 
            // KAF
            // 
            KAF.Location = new Point(290, 161);
            KAF.Name = "KAF";
            KAF.Size = new Size(221, 27);
            KAF.TabIndex = 5;
            // 
            // KelvinaFahrenheit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(BNT);
            Controls.Add(label1);
            Controls.Add(KAF);
            Name = "KelvinaFahrenheit";
            Text = "KelvinaFahrenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private Button BNT;
        private Label label1;
        private TextBox KAF;
    }
}
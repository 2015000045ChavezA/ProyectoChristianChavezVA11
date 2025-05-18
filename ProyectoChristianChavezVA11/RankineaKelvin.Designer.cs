namespace ProyectoChristianChavezVA11
{
    partial class RankineaKelvin
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
            label12 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            RAK = new TextBox();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(409, 325);
            label12.Name = "label12";
            label12.Size = new Size(23, 20);
            label12.TabIndex = 9;
            label12.Text = "Es";
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
            label1.Size = new Size(117, 20);
            label1.TabIndex = 6;
            label1.Text = "Rankine a Kelvin";
            // 
            // RAK
            // 
            RAK.Location = new Point(290, 161);
            RAK.Name = "RAK";
            RAK.Size = new Size(221, 27);
            RAK.TabIndex = 5;
            // 
            // RankineaKelvin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(RAK);
            Name = "RankineaKelvin";
            Text = "RankineaKelvin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox RAK;
    }
}
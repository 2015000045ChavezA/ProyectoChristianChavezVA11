namespace ProyectoChristianChavezVA11
{
    partial class RankineaCelcius
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
            label8 = new Label();
            label2 = new Label();
            btn = new Button();
            label1 = new Label();
            RAC = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 325);
            label8.Name = "label8";
            label8.Size = new Size(23, 20);
            label8.TabIndex = 9;
            label8.Text = "Es";
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
            // btn
            // 
            btn.Location = new Point(348, 221);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 7;
            btn.Text = "Convertir";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 106);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 6;
            label1.Text = "Rankine a Celsius";
            // 
            // RAC
            // 
            RAC.Location = new Point(290, 161);
            RAC.Name = "RAC";
            RAC.Size = new Size(221, 27);
            RAC.TabIndex = 5;
            // 
            // RankineaCelcius
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(btn);
            Controls.Add(label1);
            Controls.Add(RAC);
            Name = "RankineaCelcius";
            Text = "RankineaCelcius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label2;
        private Button btn;
        private Label label1;
        private TextBox RAC;
    }
}
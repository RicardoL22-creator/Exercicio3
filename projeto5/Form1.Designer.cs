namespace projeto5
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
            contar = new Button();
            richTextBox1 = new RichTextBox();
            caixaquantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // contar
            // 
            contar.Font = new Font("Segoe UI", 20F);
            contar.Location = new Point(86, 240);
            contar.Name = "contar";
            contar.Size = new Size(142, 50);
            contar.TabIndex = 0;
            contar.Text = "Botão";
            contar.UseVisualStyleBackColor = true;
            contar.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(271, 149);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(186, 186);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // caixaquantidade
            // 
            caixaquantidade.Location = new Point(271, 116);
            caixaquantidade.Name = "caixaquantidade";
            caixaquantidade.Size = new Size(186, 27);
            caixaquantidade.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(422, 240);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(37, 370);
            label2.Name = "label2";
            label2.Size = new Size(331, 46);
            label2.TabIndex = 4;
            label2.Text = "Ricardo Lopes Cercal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(374, 370);
            label3.Name = "label3";
            label3.Size = new Size(258, 46);
            label3.TabIndex = 5;
            label3.Text = "RA: 2024101565";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(271, 78);
            label4.Name = "label4";
            label4.Size = new Size(145, 35);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(caixaquantidade);
            Controls.Add(richTextBox1);
            Controls.Add(contar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button contar;
        private RichTextBox richTextBox1;
        private TextBox caixaquantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

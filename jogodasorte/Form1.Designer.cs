namespace jogodasorte
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            sorte = new TextBox();
            label5 = new Label();
            total = new TextBox();
            testar = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)testar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 28);
            label1.Name = "label1";
            label1.Size = new Size(250, 47);
            label1.TabIndex = 0;
            label1.Text = "Jogo da Sorte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 144);
            label2.Name = "label2";
            label2.Size = new Size(298, 30);
            label2.TabIndex = 1;
            label2.Text = "Insira um numero entre 1 e 10:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(267, 222);
            button1.Name = "button1";
            button1.Size = new Size(261, 49);
            button1.TabIndex = 3;
            button1.Text = "Jogar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 307);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 4;
            label3.Text = "Resultado final:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 367);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 5;
            label4.Text = "Numero sorteado:";
            // 
            // sorte
            // 
            sorte.Location = new Point(267, 376);
            sorte.Name = "sorte";
            sorte.Size = new Size(348, 23);
            sorte.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 415);
            label5.Name = "label5";
            label5.Size = new Size(217, 32);
            label5.TabIndex = 7;
            label5.Text = "Total de Tentativas:";
            // 
            // total
            // 
            total.Location = new Point(267, 424);
            total.Name = "total";
            total.Size = new Size(348, 23);
            total.TabIndex = 8;
            // 
            // testar
            // 
            testar.Location = new Point(327, 151);
            testar.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            testar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            testar.Name = "testar";
            testar.Size = new Size(275, 23);
            testar.TabIndex = 9;
            testar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(808, 535);
            Controls.Add(testar);
            Controls.Add(total);
            Controls.Add(label5);
            Controls.Add(sorte);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)testar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox sorte;
        private Label label5;
        private TextBox total;
        private NumericUpDown testar;
    }
}

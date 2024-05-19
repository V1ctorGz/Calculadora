namespace CalculadoraSimples
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button[] numeroBotoes;
        private System.Windows.Forms.Button botaoIgual;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button[] operacaoBotoes;

        private void InitializeComponent()
        {
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.numeroBotoes = new System.Windows.Forms.Button[10];
            this.operacaoBotoes = new System.Windows.Forms.Button[4];
            this.botaoIgual = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(12, 12);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(260, 20);
            this.displayTextBox.TabIndex = 0;

            // 
            // Numero Botoes
            // 
            for (int i = 0; i < 10; i++)
            {
                this.numeroBotoes[i] = new System.Windows.Forms.Button();
                this.numeroBotoes[i].Text = i.ToString();
                this.numeroBotoes[i].Size = new System.Drawing.Size(60, 60);
                this.numeroBotoes[i].Location = new System.Drawing.Point(12 + (i % 3) * 60, 42 + (i / 3) * 60);
                this.numeroBotoes[i].Click += new System.EventHandler(this.BotaoNumero_Click);
                this.Controls.Add(this.numeroBotoes[i]);
            }

            // 
            // Operacao Botoes
            // 
            string[] operacoes = { "+", "-", "*", "/" };
            for (int i = 0; i < operacoes.Length; i++)
            {
                this.operacaoBotoes[i] = new System.Windows.Forms.Button();
                this.operacaoBotoes[i].Text = operacoes[i];
                this.operacaoBotoes[i].Size = new System.Drawing.Size(60, 60);
                this.operacaoBotoes[i].Location = new System.Drawing.Point(192, 42 + i * 60);
                this.operacaoBotoes[i].Click += new System.EventHandler(this.BotaoOperacao_Click);
                this.Controls.Add(this.operacaoBotoes[i]);
            }

            // 
            // botaoIgual
            // 
            this.botaoIgual.Text = "=";
            this.botaoIgual.Size = new System.Drawing.Size(60, 60);
            this.botaoIgual.Location = new System.Drawing.Point(12, 282);
            this.botaoIgual.Click += new System.EventHandler(this.BotaoIgual_Click);
            this.Controls.Add(this.botaoIgual);

            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Text = "C";
            this.botaoLimpar.Size = new System.Drawing.Size(60, 60);
            this.botaoLimpar.Location = new System.Drawing.Point(72, 282);
            this.botaoLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            this.Controls.Add(this.botaoLimpar);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.displayTextBox);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
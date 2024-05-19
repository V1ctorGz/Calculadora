using System;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        private Calculadora _calculadora;

        public Form1()
        {
            InitializeComponent();
            _calculadora = new Calculadora();
        }

        private void BotaoNumero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            double numero;
            if (double.TryParse(botao.Text, out numero))
            {
                _calculadora.AdicionarNumero(numero);
                AtualizarDisplay();
            }
        }

        private void BotaoOperacao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string operacao = botao.Text;
            _calculadora.DefinirOperacao(operacao);
            AtualizarDisplay();
        }

        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            try
            {
                _calculadora.Calcular();
                AtualizarDisplay();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            _calculadora.Limpar();
            AtualizarDisplay();
        }

        private void AtualizarDisplay()
        {
            displayTextBox.Text = _calculadora.ValorAtual.ToString();
        }
    }
}
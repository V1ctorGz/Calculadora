using System;
namespace CalculadoraSimples
{
    public class Calculadora
    {
        public double ValorAtual { get; private set; }
        public double ValorAnterior { get; private set; }
        public string Operacao { get; private set; }

        public Calculadora()
        {
            Limpar();
        }

        public void Limpar()
        {
            ValorAtual = 0;
            ValorAnterior = 0;
            Operacao = string.Empty;
        }

        public void AdicionarNumero(double numero)
        {
            ValorAtual = ValorAtual * 10 + numero;
        }

        public void DefinirOperacao(string operacao)
        {
            if (!string.IsNullOrEmpty(Operacao))
            {
                Calcular();
            }
            ValorAnterior = ValorAtual;
            ValorAtual = 0;
            Operacao = operacao;
        }

        public void Calcular()
        {
            switch (Operacao)
            {
                case "+":
                    ValorAtual = ValorAnterior + ValorAtual;
                    break;
                case "-":
                    ValorAtual = ValorAnterior - ValorAtual;
                    break;
                case "*":
                    ValorAtual = ValorAnterior * ValorAtual;
                    break;
                case "/":
                    if (ValorAtual != 0)
                    {
                        ValorAtual = ValorAnterior / ValorAtual;
                    }
                    else
                    {
                        throw new DivideByZeroException("Não é possível dividir por zero.");
                    }
                    break;
                default:
                    throw new InvalidOperationException("Operação inválida.");
            }
            Operacao = string.Empty;
        }
    }
}
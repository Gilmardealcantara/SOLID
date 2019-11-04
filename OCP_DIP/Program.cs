using System;

namespace OCP_DIP
{
    class Program
    {
        public class CalculadoraDePrecos
        {
            public double Calcula(Compra produto)
            {
                TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
                Frete correios = new Frete();

                double desconto = tabela.DescontoPara(produto.Valor);
                double frete = correios.Para(produto.Cidade);

                return produto.Valor * (1 - desconto) + frete;
            }
        }

        class TabelaDePrecoPadrao
        {
            public double DescontoPara(double valor)
            {
                if (valor > 5000) return 0.03;
                if (valor > 1000) return 0.05;
                return 0;
            }
        }
        class Frete
        {
            public double Para(string cidade)
            {
                if ("SAO PAULO".Equals(cidade.ToUpper()))
                {
                    return 15;
                }
                return 30;
            }
        }

        public class Compra
        {
            public double Valor { get; set; }
            public string Cidade { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test Calc: ");
            var calc = new CalculadoraDePrecos();
            var value = calc.Calcula(new Compra { Valor = 6000.00, Cidade = "SAO PAULO" });
            Console.WriteLine(value);
        }
    }
}
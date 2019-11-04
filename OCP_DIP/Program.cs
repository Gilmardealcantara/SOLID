using System;

namespace OCP_DIP
{
    class Program
    {
        public class CalculadoraDePrecos
        {
            private readonly ITabelaDePreco _tabela;
            private readonly IServicoDeEntrega _entrega;

            public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
            {
                this._tabela = tabela;
                this._entrega = entrega;
            }

            public double Calcula(Compra produto)
            {
                double desconto = _tabela.DescontoPara(produto.Valor);
                double frete = _entrega.Para(produto.Cidade);

                return produto.Valor * (1 - desconto) + frete;
            }
        }

        class TabelaDePrecoPadrao : ITabelaDePreco
        {
            public double DescontoPara(double valor)
            {
                if (valor > 5000) return 0.03;
                if (valor > 1000) return 0.05;
                return 0;
            }
        }
        class TabelaDePrecoDiferenciada : ITabelaDePreco
        {
            public double DescontoPara(double valor)
            {
                return 0.1;
            }
        }

        class Correios : IServicoDeEntrega
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


        class Transportadora : IServicoDeEntrega
        {
            public double Para(string cidade)
            {
                if ("SAO PAULO".Equals(cidade.ToUpper()))
                {
                    return 70;
                }
                if ("BELO HORIZONTE".Equals(cidade.ToUpper()))
                {
                    return 5;
                }
                return 100;
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
            TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
            Correios correios = new Correios();
            var calc = new CalculadoraDePrecos(tabela, correios);
            var value = calc.Calcula(new Compra { Valor = 6000.00, Cidade = "SAO PAULO" });
            Console.WriteLine(value);

            Console.WriteLine("Test Calc2: ");
            TabelaDePrecoDiferenciada tabela2 = new TabelaDePrecoDiferenciada();
            Transportadora transportadora = new Transportadora();
            var calc2 = new CalculadoraDePrecos(tabela2, transportadora);
            var value2 = calc2.Calcula(new Compra { Valor = 6000.00, Cidade = "SAO PAULO" });
            Console.WriteLine(value2);
        }
    }
}
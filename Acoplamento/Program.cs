using System;
using System.Collections.Generic;

namespace Acoplamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var boletos = new List<Boleto> {
                new Boleto {Valor = 10},
                new Boleto {Valor = 50},
                new Boleto {Valor = 100},
                new Boleto {Valor = 60},
            };
            var proc = new ProcessadorDeBoletos();
            proc.Processa(boletos, new Fatura { Valor = 5000 });
        }
    }

    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {

            double total = 0;

            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.Pagamentos.Add(pagamento);
                Console.WriteLine($"pagando boleto: {boleto.Valor}");

                total += boleto.Valor;
            }

            if (total >= fatura.Valor)
            {
                fatura.Pago = true;
            }

            Console.WriteLine($"\ntotal: {total}");
            Console.WriteLine($"falta: {fatura.Valor - total}");
            Console.WriteLine($"fatura.Valor: {fatura.Valor}");
            Console.WriteLine($"fatura.Pago: {fatura.Pago}");
        }
    }

    public class Pagamento
    {
        private double _valor;
        private MeioDePagamento _meioDePagamento;

        public Pagamento(double valor, MeioDePagamento mp)
        {
            this._valor = valor;
            this._meioDePagamento = mp;
        }
    }

    public class Fatura
    {
        public IList<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        public bool Pago { get; set; } = false;
        public double Valor { get; set; }
    }

    public class Boleto
    {
        public double Valor;
    }

    public enum MeioDePagamento
    {
        BOLETO
    }
}

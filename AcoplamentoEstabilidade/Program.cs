using System;

namespace AcoplamentoEstabilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(new EnviadorDeEmail(), new NotaFiscalDao());
            geradorDeNotaFiscal.Gera(new Fatura(300, "Gilmar"));
        }
    }
}

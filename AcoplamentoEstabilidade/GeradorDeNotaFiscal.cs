using System;

namespace AcoplamentoEstabilidade
{
    class GeradorDeNotaFiscal
    {
        private EnviadorDeEmail email;
        private NotaFiscalDao dao;

        public GeradorDeNotaFiscal(EnviadorDeEmail email, NotaFiscalDao dao)
        {
            this.email = email;
            this.dao = dao;
        }

        public NotaFiscal Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));
            Console.WriteLine(nf);
            email.EnviaEmail(nf);
            dao.Persiste(nf);

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }

}
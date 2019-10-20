using System;

namespace AcoplamentoEstabilidade
{
    class GeradorDeNotaFiscal
    {
        IActionAfterNoteGeneration[] _actions;

        public GeradorDeNotaFiscal(IActionAfterNoteGeneration[] actions)
        {
            _actions = actions;
        }

        public NotaFiscal Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));
            Console.WriteLine(nf);
            foreach (var action in _actions)
                action.Exec(nf);



            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }

}
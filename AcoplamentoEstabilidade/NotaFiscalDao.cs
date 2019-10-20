using System;
namespace AcoplamentoEstabilidade
{
    class NotaFiscalDao : IActionAfterNoteGeneration
    {
        public void Exec(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}
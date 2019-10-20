using System;

namespace AcoplamentoEstabilidade
{
    public class SAP : IActionAfterNoteGeneration
    {
        public void Exec(NotaFiscal nf)
        {
            Console.WriteLine("Enviando SAP");
        }
    }
}

using System;

namespace AcoplamentoEstabilidade
{
    public class EnviadorDeEmail : IActionAfterNoteGeneration
    {
        public void Exec(NotaFiscal nf)
        {
            Console.WriteLine("Enviando email");
        }
    }
}

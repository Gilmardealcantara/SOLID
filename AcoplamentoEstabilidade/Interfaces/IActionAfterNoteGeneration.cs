using System;

namespace AcoplamentoEstabilidade
{
    public interface IActionAfterNoteGeneration
    {
        void Exec(NotaFiscal nf);
    }
}


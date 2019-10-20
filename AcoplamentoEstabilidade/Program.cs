﻿using System;

namespace AcoplamentoEstabilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            IActionAfterNoteGeneration[] actions = { new EnviadorDeEmail(), new NotaFiscalDao(), new SAP() };

            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(actions);
            geradorDeNotaFiscal.Gera(new Fatura(300, "Gilmar"));
        }
    }
}

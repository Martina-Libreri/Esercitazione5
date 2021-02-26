using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione5
{
    public class Immatricolazione
    {
        public static int matricolaSeed = 0000;
        public enum Fuoricorso
        {
            InCorso,
            FuoriCorso
        }
        public string Matricola { get; set; }
        public DateTime DataInizio { get; set; }
        public Corsi CorsoDiLaurea { get; set; }
        public Fuoricorso FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }

        public Immatricolazione(DateTime data, Corsi corso)
        {
            Matricola = matricolaSeed.ToString();
            matricolaSeed++;
            DataInizio = data;
            CorsoDiLaurea = corso;
            FuoriCorso = Fuoricorso.InCorso;
            CFUAccumulati = 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione5
{
    public class Materie
    {
        //sono i corsi associati
        public string Nome { get; set; }
        public string CFU { get; set; }
        public bool Esame { get; set; }

        public Materie(string nome, int cfu)
        {
            Nome = nome;
            CFU = cfu.ToString();
            Esame=false;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Esercitazione5
{
    class Program
    {
        static void Main(string[] args)
        {
            Corsi corsodilaurea = new Corsi(Corsi.NomeCorso.Fisica, 3, 40);

            Immatricolazione immatricolazione = new Immatricolazione(new DateTime(2020-09-16),corsodilaurea);
            Studente studente = new Studente("Martina", "Libreri",new DateTime(1995-04-27), immatricolazione);

            
            List<Materie> MaterieCorso = Corsi.CorsidiLaureaPossibili(corsodilaurea);

            Materie materia1 = new Materie("analisi",9);

            Corsi.RichiestaEsame(studente,materia1);
            
        }
    }
}

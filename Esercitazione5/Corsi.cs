using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione5
{
    public class Corsi
    {
        public enum NomeCorso
        {
            Matematica,
            Fisica,
            Informatica,
            Ingegneria,
            Lettere
        }
        public NomeCorso Nome { get; set; }
        public int AnniCorso { get; set; }
        public int CFUTot { get; set; }
        public List<Materie> CorsiAssociati { get; set; } //per ora

        public Corsi(NomeCorso nome,int anni,int cfutot)
        {
            Nome = nome;
            AnniCorso = anni;
            CFUTot = cfutot;
            CorsiAssociati = new List<Materie>();
        }

        public static List<Materie> CorsidiLaureaPossibili(Corsi corso)
        {
            var materie = new List<Materie>()
            {
                new Materie("analisi",9),
                new Materie("fisica",12),
                new Materie("informatica",6),
                new Materie("inglese",2),
            };
            var materie1 = new List<Materie>()
            {
                new Materie("analisi",9),
                new Materie("fisica",12),
                new Materie("informatica",6),
                new Materie("inglese",2),
            };
            var materie2 = new List<Materie>()
            {
                new Materie("analisi",9),
                new Materie("fisica",12),
                new Materie("informatica",6),
                new Materie("inglese",2),
            };
            var materie3 = new List<Materie>()
            {
                new Materie("analisi",9),
                new Materie("fisica",12),
                new Materie("informatica",6),
                new Materie("inglese",2),
            };
            var materie4 = new List<Materie>()
            {
                new Materie("analisi",9),
                new Materie("fisica",12),
                new Materie("informatica",6),
                new Materie("inglese",2),
            };
            if (corso.Nome == NomeCorso.Fisica)
            {
                corso.CorsiAssociati = materie;
                return materie;
            }
            else if (corso.Nome == NomeCorso.Informatica)
            {
                corso.CorsiAssociati = materie1;
                return materie1;
            }
            else if (corso.Nome == NomeCorso.Ingegneria)
            {
                corso.CorsiAssociati = materie2;
                return materie2;
            }
            else if (corso.Nome == NomeCorso.Lettere)
            {
                corso.CorsiAssociati = materie3;
                return materie3;
            }
            else
                corso.CorsiAssociati = materie4;
                return materie4;
            
        }


        public static void RichiestaEsame(Studente studente, Materie materia)
        {
            var corsoLaurea = new List<Materie>();

            Console.WriteLine("Le materie del corso di Laurea sono:");
            foreach (var item in studente.Immatricolazione.CorsoDiLaurea.CorsiAssociati)
            {
                Console.WriteLine(item.Nome +" "+ item.CFU);
                corsoLaurea.Add(item);
            }

            if (materia.Esame==false)
            {
                for(int i=0;i<corsoLaurea.Count; i++)
                {
                    if(materia.Nome == corsoLaurea[i].Nome)
                    {
                        if(Int32.Parse(materia.CFU) + studente.Immatricolazione.CFUAccumulati < studente.Immatricolazione.CorsoDiLaurea.CFUTot && studente.RichiestaLaurea ==false)
                        {
                            studente.Esami.Add(materia);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione5
{
    public class Studente
    { 
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public Immatricolazione Immatricolazione { get; set; }  
        public List<Materie> Esami { get; set; }
        public bool RichiestaLaurea { get; set; }

        //List<Corsi> corsidiLaurea = new List<Corsi>();


        public Studente(string nome,string cognome, DateTime data, Immatricolazione immatricolazione)  
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = data;
            Immatricolazione = immatricolazione;      //new Immatricolazione(new DateTime,)
            Esami = new List<Materie>();
            RichiestaLaurea = false;
        }


        public static void EsamePassato(Studente studente, string esame)
        {
            List<string> listaesami = new List<string>();
            foreach (var item in studente.Esami)
            {
                if (listaesami.Contains(esame))
                {
                    listaesami.Insert(0, item.Nome);
                    listaesami.Insert(1, item.CFU);
                }
            }
            if (listaesami.Contains(esame))
            {
                studente.Immatricolazione.CFUAccumulati += Int32.Parse(listaesami[1]);  //vado a prendere il num di cfu nella posizione dopo l'esame
                foreach (var item in studente.Immatricolazione.CorsoDiLaurea.CorsiAssociati)
                {
                    if (item.Nome == esame)
                    {
                        item.Esame = true;
                    }
                }

            }

            //se lo studente ha raggiunto il num di CFU tot del corso di laurea può richiedere la laurea
            if(studente.Immatricolazione.CFUAccumulati == studente.Immatricolazione.CorsoDiLaurea.CFUTot)
            {
                studente.RichiestaLaurea = true;
            }
        }
    }
}

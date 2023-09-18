using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {

        private string titolo;
        private string data;
        public  int CapienzaMassima { get; private set; }
        public int PostiPrenotati { get; private set; }

        public string Titolo
        {
            get
            {
                return titolo;
            }
            set
            {
                if(titolo == "")
                {
                    Console.WriteLine("Indicare il titolo dell'evento");
                }
            }
        }

        public string Data
        {
            get
            {
                return data;
            }
            set
            {
               DateTime dataOdierna = new DateTime();
                dataOdierna =  DateTime.Now;

                if (DateTime.CompareTo())
                {

                }

            }
        }



        public Evento(string titolo, string data, int PostiPrenotati)
        {
            Titolo = titolo;
            Data = data;
            CapienzaMassima = 500;
            PostiPrenotati = 0;
        }


    }
}

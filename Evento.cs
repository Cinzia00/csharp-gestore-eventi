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
        private DateTime data;
        public  int CapienzaMassima { get; private set; }
        private int postiPrenotati;

        public Evento(string titolo, string data, int postiTotali)
        {
            Titolo = titolo;
            Data = DateTime.Parse(data);
            CapienzaMassima = postiTotali;
            PostiPrenotati = 0;
        }

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
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {

                DateTime dataUtente = value;

                DateTime dataOdierna = DateTime.Now;

                if (dataUtente < dataOdierna)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.data = dataUtente;
              
            }

        }

        public int PostiPrenotati 
        { 
            get
            {
                return postiPrenotati;
            }
            set
            {
                if(postiPrenotati < 0) 
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.postiPrenotati = value;
            }


        }

        public int PrenotaPosti(int numeroPosti)
        {
            postiPrenotati += numeroPosti;
            return postiPrenotati;
        }

        public int DisdiciPosti(int postiPrenotati)
        {

            if(data < DateTime.Now || postiPrenotati == 0)
            {
                throw new ArgumentOutOfRangeException();
            }else
            {
                CapienzaMassima -= postiPrenotati;
                return CapienzaMassima;
            }       
            
        }


        public override string ToString()
        {
            return $"In data {data} ci sarà l'evento {titolo}";
        }
        




  


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticStatickeVarijable
{
    class PrvaKlasa
    {
        private static int counter;
        private string ime;
        private string prezime;
        public PrvaKlasa()
        {
            counter++;
         

        }
        public PrvaKlasa(string ime, string prezime)
        {
            counter++;
            this.ime = ime;
            this.prezime = prezime;
        }
        public int Counter { get => counter; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
       
        public override string ToString()
        {
            string ispis = "Redni broj: " + counter+", "+ ime+" "+prezime;
            
            return ispis;
        }
    }
}

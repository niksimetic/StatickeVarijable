using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticStatickeVarijable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("Nik","Simetic");
            Console.WriteLine(x.ToString());
            PrvaKlasa y = new PrvaKlasa("Matija","Tomc");
            Console.WriteLine(y.ToString());
            PrvaKlasa z = new PrvaKlasa();
            Console.WriteLine(z.ToString());

            z.Ime = "Lenco";
            z.Prezime = "Krek";
            Console.WriteLine(z.ToString());

            Console.ReadKey();
        }
    }
}

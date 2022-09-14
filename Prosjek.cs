using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // varijable
            int brojOcjena=0, ocjena;
            double prosjek=0, zbrojOcjena = 0;

            // zaglavlje aplikacije
            Console.WriteLine("########################");
            Console.WriteLine("#   Izračunavanje prosjeka   #");
            Console.WriteLine("##############################");
            Console.WriteLine("Za kraj unesi nulu. ");

            do
            {
                brojOcjena = +1;


                // unos ocjena
                Console.WriteLine("Unesi ocjenu. ");
            start: ocjena = Convert.ToInt32(Console.ReadLine());
                if (ocjena > 1 && ocjena <= 5)
                {
                    // unos u zbroj
                    zbrojOcjena += ocjena;
                }

                if (ocjena == 1)
                {
                    Console.WriteLine("Nisi prošao razred. ");
                    break;
                }

                if (ocjena > 5 || ocjena < 1)
                {
                    Console.WriteLine("Pogrešan unos. Upišite ponovno. ");
                    goto start;
                }




            } while (ocjena != 0);

            prosjek = zbrojOcjena / brojOcjena;
            Console.WriteLine(prosjek);



            Console.ReadKey();
        }
    }
}

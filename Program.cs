using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbrojIProsjek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaC klasaC = new KlasaC();
            
            Console.WriteLine(klasaC.Upis());
            Console.WriteLine(klasaC.IspisZbroj());
            Console.WriteLine(klasaC.IspisProsjek());
            Console.ReadKey();
        }
        class KlasaC
        {
            int zbroj;
            int[] brojevi = new int[5];

            public KlasaC()
            {
              
            }
            public KlasaC(int[] brojevi)
            {
                this.brojevi = brojevi;
            }

            public int[] Upis()
            {
                Console.WriteLine("Upisi te 5 brojeva");
                for(int i = 0; i < 5; i++)
                {
                    this.brojevi[i]=Convert.ToInt32(Console.ReadLine());
                }
                return (brojevi);
            }
            public string IspisZbroj()
            {
                string ispis;
                for(int i = 0; i < 5; i++)
                {
                    zbroj+= brojevi[i];
                }
                ispis = ("Zbroj brojeva je: " + zbroj);
                return ispis;
            }
            public string IspisProsjek()
            {
                string ispis;
                double prosjek;
                prosjek = zbroj / 5;
                ispis = ("Prosjek zbroja je: " + prosjek);
                return ispis;
            }

        }
    }
}

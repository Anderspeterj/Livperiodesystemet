using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
    class Program
    {
        static void Main(string[] args)
        {

            AktivitetsKatalog katalog1 = new AktivitetsKatalog("boldspil", "vanløse");
            AktivitetsKatalog katalog2 = new AktivitetsKatalog("Basket", "Holbæk");
            Console.WriteLine(katalog1);
            Console.WriteLine(katalog2);

            
            katalog1.Aktiviteter.Add(new Aktivitet(1, 13, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21)));
            katalog2.Aktiviteter.Add(new Aktivitet(1, 13, 18, new DateTime(2022, 08, 15), new DateTime(2022, 08, 22)));
            



            katalog1.PrintAktiviteter();
            katalog2.PrintAktiviteter();




            // var AktivitetsKatalog = new AktivitetsKatalog("", "", new Aktivitet(1, 15, 24, new DateTime(2022, 04, 15), new DateTime(2022, 08, 15));


           

            





        }   }
}

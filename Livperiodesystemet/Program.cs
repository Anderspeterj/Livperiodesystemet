using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
    class Program
    {
        static void Main(string[] args)
        {

            AktivitetsKatalog katalog1 = new AktivitetsKatalog("Basket", "holbæk");
            

            var aktivitet1 = new Aktivitet(1, 13, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21));
            var aktivitet2 = new Aktivitet(1, 14, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21));
            var aktivitet3 = new Aktivitet(1, 15, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21));
           
            katalog1.Aktiviteter.Add(aktivitet1);
            katalog1.Aktiviteter.Add(aktivitet2);
            katalog1.Aktiviteter.Add(aktivitet3);



            katalog1.PrintAktiviteter();

            Console.WriteLine("tast 1 for at tilføje en ny aktivitet");

            var aktivitetsKatalog = new AktivitetsKatalog("basket", "fodbold");
            var UserInput = Console.ReadLine();

            while (true)
            {
                switch (UserInput)
                {
                    case "1":
                        Console.WriteLine("Aktivitetens ID");
                        var Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("MinimumsAlder");
                        var MinAlder = Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine("MaximumsAlder");
                        var MaxAlder = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("SlutTidspunkt");
                        var startTidspunkt = DateTime.Parse(Console.ReadLine());
                        

                        Console.WriteLine("SlutTidspunkt");
                        var slutTidspunkt = DateTime.Parse(Console.ReadLine());


                        var newAktivitet = new Aktivitet(Id, MinAlder, MaxAlder, startTidspunkt,slutTidspunkt);
                        aktivitetsKatalog.AddAktivitet(newAktivitet);
                        break;

                    case "2":
                        aktivitetsKatalog.PrintAktiviteter();
                        break;
                }

                Console.WriteLine("Vælg noget nyt");
                UserInput = Console.ReadLine();
            }

            



            //AktivitetsKatalog katalog2 = new AktivitetsKatalog("Basket", "Holbæk");
            //Console.WriteLine(katalog1);
            //Console.WriteLine(katalog2);

            
            //katalog1.Aktiviteter.Add(new Aktivitet(1, 13, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21)));
            //katalog2.Aktiviteter.Add(new Aktivitet(1, 13, 18, new DateTime(2022, 08, 15), new DateTime(2022, 08, 22)));
            



            //katalog1.PrintAktiviteter();
            //katalog2.PrintAktiviteter();




            // var AktivitetsKatalog = new AktivitetsKatalog("", "", new Aktivitet(1, 15, 24, new DateTime(2022, 04, 15), new DateTime(2022, 08, 15));


           

            





        }   }
}

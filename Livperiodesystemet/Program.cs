   using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
    class Program
    {
        static void Main(string[] args)
        {

            //AktivitetsKatalog katalog1 = new AktivitetsKatalog("Basket", "holbæk");
            //HoldAktivitet holdaktivitet = new HoldAktivitet("gg");

            AktivitetsKatalog katalog2 = new AktivitetsKatalog("Fodbold", "Vanløse");
            



            var aktivitet1 = new Aktivitet(1, 9, 12, new DateTime(2022, 08, 14, 9, 00, 00), new DateTime(2022, 08, 14, 11, 00, 00));
            var aktivitet2 = new Aktivitet(2, 14, 18, new DateTime(2022, 08, 14, 12, 00, 00), new DateTime(2022, 08, 14, 14, 00, 00));
            var aktivitet3 = new Aktivitet(3, 12, 16, new DateTime(2022, 08, 14, 16, 00, 00), new DateTime(2022, 08, 21, 17, 00, 00));



            katalog2.AddAktivitetDic(aktivitet1);
            katalog2.AddAktivitetDic(aktivitet2);
            katalog2.AddAktivitetDic(aktivitet3);

            Console.WriteLine(katalog2);









            Console.WriteLine();

            Console.WriteLine("Velkommen til LivperiodeSystemet");
            Console.WriteLine("");
           


            
            //var UserInput = Console.ReadLine();

            //while (true)
            //{


            //    switch (UserInput)
            //    {
            //        case "1":

            //            katalog1.AddAktivitet();

            //            break;

            //        case "2":
            //            Console.Clear();
            //            katalog1.ToString();
                        
            //            break;

            //        case "3":
            //            Console.Clear();
            //            Console.WriteLine("Indtast nummeret på den aktivitet du gerne vil slette");
            //            var Id = Convert.ToInt32(Console.ReadLine());
            //            katalog1.DeleteAktivitet(Id);
            //            Console.WriteLine($"Aktivitet nummer {Id}, er hermed slettet");
            //            break;

            //        case "4":
            //            Console.Clear();
            //            Console.WriteLine("Indtast nummeret på den aktivtet som du gerne vil opdatere");
            //            Id = Convert.ToInt32(Console.ReadLine());
            //            katalog1.UpdateAktivitet(Id);

            //            //Console.WriteLine($"Aktivitet nummer {Id}, er hermed opdateret");
            //            break;

            //        case "x":
            //            Console.Clear();
            //            Console.WriteLine("Tryk 5 for at få vist brugermenuen igen");
            //            break;

            //        case "5":
            //            Console.Clear();
            //            katalog1.brugerMenu();

            //            break;

            //    }

            //    UserInput = Console.ReadLine();



            //}

        }
    }
}

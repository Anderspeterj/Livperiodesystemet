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
            



            var aktivitet1 = new Aktivitet(1, "ggwp", 9, 12, new DateTime(2022, 08, 14, 9, 00, 00), new DateTime(2022, 08, 14, 11, 00, 00));
            var aktivitet2 = new Aktivitet(2, "ggwplol", 14, 18, new DateTime(2022, 08, 14, 12, 00, 00), new DateTime(2022, 08, 14, 14, 00, 00));
            var aktivitet3 = new Aktivitet(3, "ggwpff", 12, 16, new DateTime(2022, 08, 14, 16, 00, 00), new DateTime(2022, 08, 21, 17, 00, 00));



            

            Console.WriteLine(katalog2);
            Console.WriteLine(aktivitet1._id);
            Console.WriteLine(aktivitet2.Id);









            Console.WriteLine();

            Console.WriteLine("Velkommen til LivperiodeSystemet");
            Console.WriteLine("");
            Console.WriteLine("1 for add");
            Console.WriteLine("2 for update");
            Console.WriteLine("3 for search");




            var UserInput = Console.ReadLine();

            while (true)
            {


                    switch (UserInput)
                    {
                        case "1":

                        Console.Clear();
                        katalog2.AddAktivitet();
                        break;

                    case "2":
                        Console.Clear(); 
                        Console.Clear();
                        Console.WriteLine("Vælg et nummer fra menuen for at opdatere din pizza");
                        Console.WriteLine();
                        katalog2.PrintAktiviteter();
                        int nummer = Convert.ToInt32(Console.ReadLine());
                        katalog2.UpdateAktivitet(nummer);

                        break;

                        case "3":
                        Console.Clear();
                        Console.WriteLine("Søg efter en aktivitet via. navn");
                        Console.WriteLine();
                        var searchPhrase = Console.ReadLine();

                        katalog2.VisMatchendeAkitivteter(searchPhrase);


                        break;

                       

                    }

                    UserInput = Console.ReadLine();



                }

            }
    }
}

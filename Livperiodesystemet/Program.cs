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
            HoldAktivitet holdaktivitet = new HoldAktivitet("gg");

           

            var aktivitet1 = new Aktivitet(1, 13, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21));
            var aktivitet2 = new Aktivitet(2, 14, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21));
            var aktivitet3 = new Aktivitet(3, 15, 18, new DateTime(2022, 08, 14), new DateTime(2022, 08, 21));
            


            katalog1.Aktiviteter.Add(aktivitet1);
            katalog1.Aktiviteter.Add(aktivitet2);
            katalog1.Aktiviteter.Add(aktivitet3);



            holdaktivitet.ToString();
            Console.WriteLine("Velkommen til LivperiodeSystemet");
            Console.WriteLine("");
            katalog1.brugerMenu();

            holdaktivitet.ToString();
            Console.WriteLine(holdaktivitet.ToString());

            var UserInput = Console.ReadLine();

            while (true)
            {
               
                
                    switch (UserInput)
                    {
                        case "1":

                        katalog1.AddAktivitet();
                        
                        break;



                    case "2":
                        Console.Clear();
                        katalog1.ToString();
                        katalog1.PrintAktiviteter();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Indtast nummeret på den aktivitet du gerne vil slette");
                        var Id = Convert.ToInt32(Console.ReadLine());
                        katalog1.DeleteAktivitet(Id);
                        Console.WriteLine($"Aktivitet nummer {Id}, er hermed slettet");
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Indtast nummeret på den aktivtet som du gerne vil opdatere");
                        Id = Convert.ToInt32(Console.ReadLine());
                        katalog1.UpdateAktivitet(Id);
                        
                        //Console.WriteLine($"Aktivitet nummer {Id}, er hermed opdateret");
                        break;

                    case "x":
                        Console.Clear();
                        Console.WriteLine("Tryk t for at få vist brugermenuen igen");
                        break;

                    case "t":
                        Console.Clear();
                        katalog1.brugerMenu();

                        break;

                }

                UserInput = Console.ReadLine();



            }
                
                
                















             
}   }   }

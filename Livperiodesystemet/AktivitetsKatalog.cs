using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Livperiodesystemet
{
    public class AktivitetsKatalog
    {
        
        


        public string AktivitetsNavn { get; set; }
        public string Lokation { get; set; }
        public List<Aktivitet> Aktiviteter { get; set; }


        public AktivitetsKatalog(string aktivitetsNavn, string lokation)
            
        {
            Lokation = lokation;
            AktivitetsNavn = aktivitetsNavn;
            Aktiviteter = new List<Aktivitet>();

        }


        

        public override string ToString()
        {
            return $"Aktivitetsnavn:{AktivitetsNavn}, lokation:{Lokation}";

        }

        public void PrintAktiviteter()
        {
            foreach (Aktivitet aktivitet in Aktiviteter)
            {
                Console.WriteLine($"{AktivitetsNavn}, {Lokation}, {aktivitet.Id}, {aktivitet.MinAlder}  {aktivitet.MaxAlder}  {aktivitet.StartTidspunkt}  {aktivitet.SlutTidspunkt}");
                Console.WriteLine("___________________________");
                Console.WriteLine("___________________________");
            }
        }

        public void AddAktivitet(Aktivitet aktivitet)
        {
            Aktiviteter.Add(aktivitet);
        }

        public void DeleteAktivitet(int Id)
        {
            Aktiviteter.RemoveAt(Id - 1); 
        }

        public void UpdateAktivitet(int Id)
        {
            
            
                try
                {
                    var aktivitet = Aktiviteter.FirstOrDefault(a => a.Id == Id);
                    if (aktivitet == null)
                    {
                        Console.WriteLine("Aktivitet ikke fundet");
                    }
                    else
                    {
                        //Console.WriteLine("Indtast nummeret på den aktivtet du gerne vil opdatere");
                        //Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"du har valgt {Id}, vælg det nye ID");
                        aktivitet.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("vælg ny minalder");
                        aktivitet.MinAlder = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("vælg ny maxalder");
                        aktivitet.MaxAlder = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Vælg ny dateTime");
                        aktivitet.StartTidspunkt = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("vælg ny DateTime");
                        aktivitet.SlutTidspunkt = Convert.ToDateTime(Console.ReadLine());



                    }
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Venligst kun indsæt datoen i følgende format : 00-00-20xx");
                Console.WriteLine("Tast 5 for at vende tilbage");


            }
            
        }
            
       
        public void brugerMenu()
        {
            Console.WriteLine("Tast 1 for at tilføje en ny aktivitet");
            Console.WriteLine("______________________________________");
            Console.WriteLine("Tast t for at få vist brugermenuen");
            Console.WriteLine();
            Console.WriteLine("Tast 2 for at se alle aktiviteterne");
            Console.WriteLine();
            Console.WriteLine("Tast 3 for at slette den valgte aktivtet");
            Console.WriteLine();
            Console.WriteLine("Tast 4 for at vælg den aktivitet du gerne vil opdatere");
            Console.WriteLine();
            Console.WriteLine("Tast t for at få vist brugermenuen igen");
        }
     



    }
}

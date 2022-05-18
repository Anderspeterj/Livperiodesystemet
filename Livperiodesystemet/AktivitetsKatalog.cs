using System;
using System.Collections.Generic;
using System.Text;

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


    }
}

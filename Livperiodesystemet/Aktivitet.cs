using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
   public class Aktivitet
    {
       public int Id { get; set; }
       public int MinAlder { get; set; }
       public int MaxAlder { get; set; }
       public DateTime StartTidspunkt { get; set; }
       public DateTime SlutTidspunkt { get; set; }


        public Aktivitet(int id, int minAlder, int maxAlder)
        {
            Id = id;
            MinAlder = minAlder;
            MaxAlder = maxAlder;

        }

        public Aktivitet(int id, int minAlder, int maxAlder, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            Id = id;
            MinAlder = minAlder;
            MaxAlder = maxAlder;
            StartTidspunkt = startTidspunkt;
            SlutTidspunkt = slutTidspunkt; 
        }



        public override string ToString()
        {
            return $"Id:{Id}, minimumsAlder:{MinAlder} MaksAlder:{MaxAlder}, startTidspunkt{StartTidspunkt}, slutTidspunkt {SlutTidspunkt}";

        }
    }
}

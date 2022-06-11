 using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
    class HoldAktivitet : Aktivitet
    {
        public string HoldId { get; set; }


        public HoldAktivitet(int Id, int minAlder, int maxAlder, DateTime startTidspunkt, DateTime slutTidspunkt,
            string holdId) : base (Id, minAlder, maxAlder, startTidspunkt, slutTidspunkt)

        {
            HoldId = holdId;
        }


        public override string ToString()
        {
            int i = 0;
            while (i == 1);
            

            foreach (HoldAktivitet aktivitet in Aktiviteter)
            {
                return $"HoldId: {HoldId}, Id:{Id}, minimumsAlder:{MinAlder} MaksAlder:{MaxAlder}, startTidspunkt{StartTidspunkt}, slutTidspunkt {SlutTidspunkt}";
                i++;
            }

        }
    }
}

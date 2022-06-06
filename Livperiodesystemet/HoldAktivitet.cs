 using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
    class HoldAktivitet : Aktivitet
    {
        public string HoldId { get; set; }
        
       
        public HoldAktivitet(string holdId)
        {
            HoldId = holdId;
        }
       

        public override string ToString()
        {
            int i = 0;
            do
            {
                return $"HoldId: {HoldId}, Id:{Id}, minimumsAlder:{MinAlder} MaksAlder:{MaxAlder}, startTidspunkt{StartTidspunkt}, slutTidspunkt {SlutTidspunkt}";
            }
            while (i < 5);
        }
    }
}

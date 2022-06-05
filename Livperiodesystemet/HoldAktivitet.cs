using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
    class HoldAktivitet : Aktivitet
    {
        public string HoldId { get; set; }
        
       
        public HoldAktivitet(string holdId, int id, int minAlder, int maxAlder, DateTime startTidspunkt, DateTime slutTidspunkt) : base (id, minAlder, maxAlder, startTidspunkt, slutTidspunkt)
        {
            HoldId = holdId;
        }

        public override string ToString()
        {
            return $"{HoldId}";
        }
    }
}

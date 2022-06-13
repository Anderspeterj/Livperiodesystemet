using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet
{
    public class Aktivitet
    {
        public int _id;
        public string _navnId;
        public int _minAlder;
        public int _maxAlder;
        public DateTime _startTidspunkt;
        public DateTime _slutTidspunkt;


        public Aktivitet(int id, string navnId, int minAlder, int maxAlder, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            _id = id;
            _minAlder = minAlder;
            _maxAlder = maxAlder;
            _startTidspunkt = startTidspunkt;
            _slutTidspunkt = slutTidspunkt;
            _navnId = navnId;
        }

        public Aktivitet()
        {

        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string NavnId
        {
            get { return _navnId; }
            set { _navnId = value; }
        }
        public int MinAlder
        {
            get { return _minAlder; }
            set { _minAlder = value; }
        }
        public int MaxAlder
        {
            get { return _maxAlder; }
            set { _maxAlder = value; }
        }
        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; }
        }
        public DateTime SlutTidspunkt
        {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; }
        }

        public override string ToString()
        {
            return $"Id:{Id}, navnId: {NavnId}, minimumsAlder:{MinAlder} MaksAlder:{MaxAlder}, startTidspunkt{StartTidspunkt}, slutTidspunkt {SlutTidspunkt}";

        }


  

    }
}

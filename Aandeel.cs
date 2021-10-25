using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Aandeel
    {
        public string Symbool { get; set; }
        public string Naam { get; set; }
        public string Land { get; set; }
        public List<Transactie> Transacties { get; set; }

        public Aandeel()
        {
            Transacties = new List<Transactie>();
        }

        public override string ToString()
        {
            return "Naam: " + Naam + ", Symbool: " + Symbool + ", Land: " + Land;
        }

        public void NieuweTransactie(DateTime datum, int aantal, double koers, Transactie.TransactieTypen type)
        {
            Transacties.Add(new Transactie() { Aantal = aantal, Datum = datum, Koers = koers, Type = type });
        }
    }

    internal class Transactie
    {
        public enum TransactieTypen { Aankoop, Verkoop }
        public DateTime Datum { get; set; }
        public int Aantal { get; set; }
        public double Koers { get; set; }
        public TransactieTypen Type { get; set; }

        public override string ToString()
        {
            return "    --> " + Datum.ToString() + " " + Type.ToString() + ": " + Aantal + "aan €" + Koers;
        }
    }
}

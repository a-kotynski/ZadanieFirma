using System;

namespace Tue052022
{
    public enum NazwaKontraktu
    {
        Staz = 0,
        Etat = 1,
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pracownik = new Pracownik("Artur", "Szwed");

            Console.WriteLine(pracownik.kontrakt.NazwaKontraktu + " / " + pracownik.kontrakt.Pensja());
        }
    }

    public class Pracownik
    {
        private readonly string imie;
        private readonly string nazwisko;
        public Kontrakt kontrakt; // composition?
        public Pracownik(string i, string n)
        {
            imie = i;
            nazwisko = n;
            kontrakt = new Staz();
        }

        public void zmienKontrakt(Typ typ)
        {
        }
    }

    public class Kontrakt
    {
        public NazwaKontraktu NazwaKontraktu;
        public decimal Stawka;
        public int IloscNadgodzin;

        public Kontrakt() { }
        public Kontrakt(NazwaKontraktu nk, decimal st, int iln)
        {
            NazwaKontraktu = nk;
            Stawka = st;
            IloscNadgodzin = iln;
        }

        public virtual decimal Pensja()
        {
            return Stawka;
        }
    }

    public class Staz : Kontrakt
    {
        public Staz(decimal s, int iln) { }
        public override decimal Pensja()
        {
            return stawka;
        }
    }

    public class Etat : Kontrakt
    {
        private readonly decimal stawka = 5000;
        private readonly int iloscNadgodzin = 0;
        public override decimal Pensja()
        {
            return stawka + iloscNadgodzin * (stawka / 60);
        }
    }
}
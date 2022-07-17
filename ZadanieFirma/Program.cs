using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.is.umk.pl/~grochu/wiki/doku.php?id=zajecia:po:csharp_dziedziczenie

// myattempt2 branch zawiera więcej kodu z ze spotkania 05.07

namespace ZadanieFirma
{
    public enum NazwaKontraktu
    {
        Staz = 0,
        Etat = 1,
    }
    class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public NazwaKontraktu Kontrakt { get; set; }
        public Pracownik()
        {

        }
        public Pracownik(string imie, string nazwisko, NazwaKontraktu? kontrakt)
            // kontrakt domyślny = null?
        {
            Imie = imie;
            Nazwisko = nazwisko;
            switch (kontrakt)
            {
                case null:
                    Kontrakt = (NazwaKontraktu)0;
                    break;
                case NazwaKontraktu.Staz:
                    Kontrakt = (NazwaKontraktu)0;
                    break;
                case NazwaKontraktu.Etat:
                    Kontrakt = (NazwaKontraktu)1;
                    break;
                default:
                    break;
            }
            
        }
        public void ZmianaKontraktu(string zmianaKontraktu)
        {
            switch (zmianaKontraktu.ToLower().Trim())
            {
                case "staz":
                    Kontrakt = (NazwaKontraktu)0;
                    break;
                case "etat":
                    Kontrakt = (NazwaKontraktu)1;
                    break;
                default:
                    break;
            }
        }
        public decimal PensjaZaleznaOdKontraktu()
        {
            decimal stazPensja = 1000;
            decimal etatPensja = 5000;

            switch (Kontrakt)
            {
                case NazwaKontraktu.Staz:
                    return stazPensja;
                case NazwaKontraktu.Etat:
                    return etatPensja;
                default:
                    return 0;
            }
        }
    }
    public class Kontrakt
    {
        public NazwaKontraktu NazwaKontraktu { get; set; }
        public decimal Stawka { get; set; }
        public int IloscNadgodzin { get; set; }
        public Kontrakt()
        {

        }
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
        public Staz()
        {
            Stawka = 1000;
        }
    }
    public class Etat : Kontrakt
    {
        public Etat()
        {
            Stawka = 5000 + IloscNadgodzin * (5000/60);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var kontrakt = new Kontrakt((NazwaKontraktu)1, 1500, 2);
            Console.WriteLine("Stawka kontraktu: " + kontrakt.Stawka);

            var staz = new Staz();
            var etat = new Etat();
            Console.WriteLine("Stawka stazu: " + staz.Stawka);
            Console.WriteLine("Stawka etatu: " + etat.Stawka);
            
            var pracownik = new Pracownik("Imie", "Nazwisko", null);
            Console.WriteLine("Dane pracownika: " + pracownik.Imie +" " + pracownik.Nazwisko + " " + pracownik.Kontrakt);
        }
    }
}
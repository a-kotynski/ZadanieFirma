using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.is.umk.pl/~grochu/wiki/doku.php?id=zajecia:po:csharp_dziedziczenie

// 1 Problem - zmiana prop Kontrakt w metodzie ZmianaKontraktu
// 1 Solved by using casting


namespace ZadanieFirma
{
    public enum NazwaKontraktu : int
    {
        Staz = 0,
        Etat = 1,
    }
    class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public NazwaKontraktu Kontrakt { get; set; }
        public Pracownik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Kontrakt = (NazwaKontraktu)0;
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
        public int PensjaKontrakt()
        {
            int stazPensja = 1000;
            int etatPensja = 5000;

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
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Samochod
    {
        private string Marka;
        private int LiczbaKol;
        public int Predkosc;
        private string Kolor;
        private int Rocznik;

        public Samochod(string Marka, int LiczbaKol, int Predkosc, string Kolor = "Czarny", int Rocznik = 2016)
        {
            this.Marka = Marka;
            this.LiczbaKol = LiczbaKol;
            this.Predkosc = Predkosc;
            this.Kolor = Kolor;
            this.Rocznik = Rocznik;
        }

        public void Jedz(int predkosc)
        {
            Console.WriteLine(this.Kolor + " samochod marki " + this.Marka + " jedzie z predkoscia " + predkosc + " km/h");
            Console.WriteLine("Domyslna ilosc kol uzywanych jednoczesnie w samochodzie to " + this.LiczbaKol);
        }

        public void Hamuj()
        {
            Console.WriteLine("Samochod " + this.Marka + " hamuje.");
        }
    }
}

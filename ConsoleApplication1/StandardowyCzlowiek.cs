using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StandardowyCzlowiek
    {
        private string Imie;
        private int Wiek;
        public static int IloscKosciSzkieletowych = 206;
        private string MiejscePochodzenia;
        public static int IloscChromosomow = 46;

        public StandardowyCzlowiek(string Imie, int Wiek, string MiejscePochodzenia)
        {
            this.Imie = Imie;
            this.Wiek = Wiek;
            this.MiejscePochodzenia = MiejscePochodzenia;
        }

        public int getWiek()
        {
            return this.Wiek;
        }

        public string getImie()
        {
            return this.Imie;
        }
        public string getMiejscePochodzenia()
        {
            return this.MiejscePochodzenia;
        }
    }
}

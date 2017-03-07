using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class KontoBankowe
    {
        public string Imie;
        public string Nazwisko;
        public string NrKonta;
        public double Fundusze;
        private int id;
        public string status;

        static int nr = 1;

        public KontoBankowe(string Imie, string Nazwisko, string NrKonta, double Fundusze)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.NrKonta = NrKonta;
            this.Fundusze = Fundusze;
            this.id = nr;
            this.status = "Aktywny";
            nr++;
        }

        public void WplacPieniadze(double kwota)
        {
            ZmienFunduszeKonta(this.Fundusze + kwota);
        }

        private void ZmienFunduszeKonta(double fundusze)
        {
            this.Fundusze = fundusze;
        }

        public void UsunKonto()
        {

        }
        public void WyplacPieniadze(double kwota)
        {
            ZmienFunduszeKonta(this.Fundusze - kwota);
        }
        public void setStatus(string status)
        {
            this.status = status;
        }

    }
}

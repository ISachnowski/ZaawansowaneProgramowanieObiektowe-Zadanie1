using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1

            //List<Samochod> ListaSamochodow = new List<Samochod>();
            //Samochod ford = new Samochod("ford", 4, 50);
            //ListaSamochodow.Add(ford);
            //Samochod opel = new Samochod("Opel", 4, 120, "niebieski", 2015);
            //ListaSamochodow.Add(opel);
            //Samochod honda = new Samochod("Honda", 4, 200, "zielony", 1996);
            //ListaSamochodow.Add(honda);

            //foreach (Samochod samochod in ListaSamochodow)
            //{
            //    samochod.Jedz(samochod.Predkosc);
            //}


            //Zadanie 2

            //List<KontoBankowe> ListaKont = new List<KontoBankowe>();
            //KontoBankowe Konto1 = new KontoBankowe("Igor", "Sachnowski", "123123123", 543.33);
            //ListaKont.Add(Konto1);
            //KontoBankowe Konto2 = new KontoBankowe("John", "Doe", "456456456", 122.43);
            //ListaKont.Add(Konto2);
            //KontoBankowe Konto3 = new KontoBankowe("Jan", "Kowalski", "789789789", 122.33);
            //ListaKont.Add(Konto3);
            //Console.WriteLine("Dostepne konta bankowe: ");
            //foreach (KontoBankowe konto in ListaKont)
            //{
            //    Console.WriteLine(konto.Imie + " " + konto.Nazwisko + ". Saldo: " + konto.Fundusze + ". Status: " + konto.status);
            //}

            //Console.WriteLine("Wybierz nr konta");
            //int wyborKonta = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    KontoBankowe wybraneKonto = ListaKont[wyborKonta - 1];
            //    int wybor = -1;
            //    while (wybor != 0)
            //    {

            //        Console.WriteLine("Wybrano konto: " + wybraneKonto.Imie + " " + wybraneKonto.Nazwisko + ". Stan konta: " + wybraneKonto.Fundusze);
            //        Console.WriteLine("Wybierz opcje:");
            //        Console.WriteLine("1 - Wplac pieniadze");
            //        Console.WriteLine("2 - Dodaj odsetki");
            //        Console.WriteLine("3 - Ustaw konto do usuniecia");
            //        Console.WriteLine("4 - Aby wyswietlic konta");
            //        Console.WriteLine("0 - Aby zakonczyc");
            //        wybor = Convert.ToInt32(Console.ReadLine());
            //        if (wybor == 1)
            //        {
            //            Console.WriteLine("Podaj kwote ktora chcesz wplacic.");
            //            double kwota = Convert.ToDouble(Console.ReadLine());
            //            wybraneKonto.WplacPieniadze(kwota);
            //        }
            //        else if (wybor == 2)
            //        {
            //            Console.WriteLine("Podaj procent odsetek o jaki chcesz zwiekszyc stan konta");
            //            double procent = Convert.ToDouble(Console.ReadLine());
            //            if (procent < 0)
            //            {
            //                Console.WriteLine("Niepoprawna wartosc");
            //            }
            //            else
            //            {
            //                wybraneKonto.WplacPieniadze((wybraneKonto.Fundusze * (procent / 100 + 1)) - wybraneKonto.Fundusze);
            //            }
            //        }
            //        else if (wybor == 3)
            //        {
            //            Console.WriteLine("Czy chcesz ustawić status konta na 'Do usuniecia'? Wpisz 'TAK' aby potwierdzić.");
            //            string usunWybor = "";
            //            usunWybor = Console.ReadLine();
            //            if (usunWybor == "TAK")
            //            {
            //                wybraneKonto.setStatus("Do usuniecia");
            //            }


            //        }
            //        else if (wybor == 4)
            //        {
            //            Console.WriteLine("Dostepne konta bankowe: ");
            //            foreach (KontoBankowe konto in ListaKont)
            //            {
            //                Console.WriteLine(konto.Imie + " " + konto.Nazwisko + ". Saldo: " + konto.Fundusze + ". Status: " + konto.status);
            //            }
            //        }
            //    }

            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine("Zly numer konta.", e);
            //}

            // Zadanie 3

            List<StandardowyCzlowiek> ListaLudzi = new List<StandardowyCzlowiek>();
            StandardowyCzlowiek Czlowiek1 = new StandardowyCzlowiek("Igor", 23, "Olsztyn");
            ListaLudzi.Add(Czlowiek1);
            StandardowyCzlowiek Czlowiek2 = new StandardowyCzlowiek("Jan", 15, "Olsztyn");
            ListaLudzi.Add(Czlowiek2);
            StandardowyCzlowiek Czlowiek3 = new StandardowyCzlowiek("Andrzej", 22, "Warszawa");
            ListaLudzi.Add(Czlowiek3);
            StandardowyCzlowiek Czlowiek4 = new StandardowyCzlowiek("Piotr", 33, "Wrocław");
            ListaLudzi.Add(Czlowiek4);
            StandardowyCzlowiek Czlowiek5 = new StandardowyCzlowiek("Paweł", 41, "Gdańsk");
            ListaLudzi.Add(Czlowiek5);


            int wybor = -1;
            while (wybor != 0)
            {
                Console.WriteLine("Wybierz:");
                Console.WriteLine("1 - Wylicz srednia wieku wszystkich obiektow.");
                Console.WriteLine("2 - Wypisz wszytkie imiona.");
                Console.WriteLine("3 - Podaj uniwersalne dane czlowieka");
                Console.WriteLine("4 - Wypisz najczesciej wystepujace miejsce pochodzenia");
                Console.WriteLine("0 - Aby wyjsc");
                wybor = Convert.ToInt32(Console.ReadLine());
                if (wybor == 1)
                {

                    int suma = 0;
                    foreach (StandardowyCzlowiek Czlowiek in ListaLudzi)
                    {
                        suma += Czlowiek.getWiek();
                    }
                    Console.WriteLine("Srednia wieku wynosi: {0}", suma / ListaLudzi.Count);
                }
                else if (wybor == 2)
                {
                    foreach (StandardowyCzlowiek Czlowiek in ListaLudzi)
                    {
                        Console.WriteLine(Czlowiek.getImie());
                    }
                }
                else if (wybor == 3)
                {
                    Console.WriteLine("Uniwersalne dane człowieka: ");
                    Console.WriteLine("Ilosc kosci szkieletowych: " + StandardowyCzlowiek.IloscKosciSzkieletowych);
                    Console.WriteLine("Ilosc chromosomow: " + StandardowyCzlowiek.IloscChromosomow);
                }
                else if (wybor == 4)
                {
                    Dictionary<string, int> listaNajczesciejWystepujacych = new Dictionary<string, int>();
                    string miejscePochodzenia = "";
                    foreach (StandardowyCzlowiek Czlowiek in ListaLudzi)
                    {
                        miejscePochodzenia = Czlowiek.getMiejscePochodzenia();
                        if (listaNajczesciejWystepujacych.Keys.Contains(miejscePochodzenia))
                        {
                            listaNajczesciejWystepujacych[miejscePochodzenia]++;
                        }
                        else
                        {
                            listaNajczesciejWystepujacych.Add(miejscePochodzenia, 1);
                        }
                    }
                    Console.WriteLine(listaNajczesciejWystepujacych.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);
                }
                else if (wybor != 0)
                    Console.WriteLine("Zly wybor.");
            }
        }
    }
}

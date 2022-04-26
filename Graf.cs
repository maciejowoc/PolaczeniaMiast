using System;
using System.Collections.Generic;
using System.IO;

namespace PolaczeniaMiast
{
    class Graf
    {

        public List<Wierzcholek> wierzcholki = new List<Wierzcholek>();                //Generacja listy wierzchołków        

        public Graf(System.IO.StreamReader plik)
        {

            string linia;
            //_________ZAŁADOWANIE Z PLIKU___________
            
            while ((linia = plik.ReadLine()) != null)                           //Dopóki są zapełnione linie tekstu
            {
                string[] linie = linia.Split(',');                              //Tablica przechowuje pocięte spacjami linie tekstu
                string nazwa = linie[0];                                        //Poszczególne elementy linii przechowują odpowiednie dane
                int idMiasta = Convert.ToInt32(linie[1]);
                int[] polaczenia = new int[(linie.Length - 2) / 2];
                int[] dlugosci = new int[(linie.Length - 2) / 2];
                for (int i = 0; i < (linie.Length - 2) / 2; i++)
                {
                    polaczenia[i] = Convert.ToInt32(linie[i + 2]);
                }
                for (int i = (linie.Length + 2) / 2; i < linie.Length; i++)
                {
                    dlugosci[i - (linie.Length + 2) / 2] = Convert.ToInt32(linie[i]);
                }
                wierzcholki.Add(new Wierzcholek(nazwa, idMiasta, polaczenia));  //Tworzenie wierzchołka o podanych wcześniej parametrach
                foreach (int d in dlugosci)
                {
                    wierzcholki[wierzcholki.Count - 1].dlugosc.Add(d);
                }
            }

        }

        public Graf()
        {

        }

        public bool SprawdzKrawedz(int start, int koniec)                       //Sprawdza czy istnieje połączenie między wierzchołkami
        {
            if (start > koniec)                                                  //Jeżeli element końcowy jest większy to odwraca elementy
            {
                return SprawdzKrawedz(koniec, start);
            }
            return wierzcholki[start].SprawdzPolaczenie(koniec);
        }

        public int Zaladuj(string miasto)                                       //Zwraca id poszukiwanego po nazwie miasta
        {
            foreach (Wierzcholek wierz in wierzcholki)
            {
                if (miasto == wierz.nazwa) return wierz.id;
            }

            return 1;
        }

        readonly List<string> nazwy = new List<string>();                             //Przechowuje nazwy poszczególnych miast na drodze do celu
        public int dlugosc = 0;

        struct Dane                     //Struktura wykorzystana do przechowywania informacji o wierzchołku
        {
            public int dystans;
            public int poprzednik;
            public bool odwiedzony;
        };

        static int SzukajMinimum(ref Dane[] tab)            //Funkcja znajduje minimalny dystans z tabeli wierzchołków
        {
            int min = -1;
            int mindist = int.MaxValue;
            for (int i = 0; i < tab.Length; i++)
            {
                if (!tab[i].odwiedzony && tab[i].dystans < mindist)
                {
                    min = i;
                    mindist = tab[i].dystans;
                }
            }
            return min;
        }

        static Dane[] Dijkstra(int[,] macierz, int start)                   //Realizacja algorytmu Dijkstry
        {
            Dane[] tab = new Dane[macierz.GetLength(0)];
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                tab[i].dystans = (i == start) ? 0 : int.MaxValue;
                tab[i].odwiedzony = false;
                tab[i].poprzednik = -1;
            }
            int u = start;
            while (u != -1)
            {
                tab[u].odwiedzony = true;
                for (int i = 0; i < macierz.GetLength(0); i++)
                {
                    if (macierz[u, i] > 0 && tab[u].dystans + macierz[u, i] < tab[i].dystans)
                    {
                        tab[i].dystans = tab[u].dystans + macierz[u, i];
                        tab[i].poprzednik = u;
                    }
                }
                u = SzukajMinimum(ref tab);
            }
            return tab;
        }

        void WypiszDane(int meta, Dane[] d)             //Wypisuje dane z otrzymanej tablicy wynikowej
        {
            int u = meta;
            dlugosc = d[u].dystans;
            nazwy.Add(wierzcholki[u].nazwa);
            while (d[u].poprzednik != -1)
            {
                nazwy.Add(wierzcholki[d[u].poprzednik].nazwa);
                u = d[u].poprzednik;
            }

        }

        public List<string> Droga(int start, int meta)              //Funkcja generuje trasę i liczy dystans
        {
            nazwy.Clear();
            int n = wierzcholki.Count;                      //n - liczba elementów w bazie danych
            int[,] sasiady = new int[n, n];                 //Tablica sąsiedztwa
            for (int i = 0; i < n; i++)                     //Zerowanie tablicy
            {
                for (int j = 0; j < n; j++)
                {
                    sasiady[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)                     //Wprowadzanie wartości z bazy danych to tablicy sąsiedztwa
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i) sasiady[i, j] = 0;
                    else
                    {
                        if (!wierzcholki[i].polaczenia.Contains(j)) sasiady[i, j] = 10000;
                        else
                            sasiady[i, j] = wierzcholki[i].dlugosc[wierzcholki[i].polaczenia.IndexOf(j)];
                    }
                }
            }
            Dane[] tabela = Dijkstra(sasiady, start);
            WypiszDane(meta, tabela);
            nazwy.Reverse();
            return nazwy;
        }
    }
}
    //public class BladEventArgs : EventArgs
    //{
    //    public string komunikat { get; set; }
    //    public string tytul { get; set; }
    //}

    //public delegate void BladEventHandler(Object sender, BladEventArgs e);



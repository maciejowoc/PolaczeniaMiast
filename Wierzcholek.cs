using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolaczeniaMiast
{
    class Wierzcholek
    {

        public string nazwa = "Brak nazwy";
        public int id;
        public List<int> polaczenia = new List<int>();                     //Tworzona jest lista połączeń pomiędzy wierzchołkami
        public List<int> dlugosc = new List<int>();                        //Tworzona jest lista długości odpowiadających połączeń

        public bool SprawdzPolaczenie(int cel)
        {
            return polaczenia.IndexOf(cel) != -1;               //Sprawdza czy połączenie z danym wierzchołkiem istnieje
        }

        public bool dodajKrawedz(int cel)
        {
            if (SprawdzPolaczenie(cel))                             //Jeżeli istnieje połączenie to nic nie rób
            {                                                       //Jeżeli jednak nie istnieje to utwórz nowe połączenie
                return false;                               
            }
            else
            {
                polaczenia.Add(cel);
                return true;
            }
        }

        public Wierzcholek(string _nazwa, int _id, params int[] polaczenia)
        {
            nazwa = _nazwa;
            id = _id;
            foreach (int krawedz in polaczenia) dodajKrawedz(krawedz);          //Dodawanie dynamicznych połączeń do wierzchołka id
        }

        public Wierzcholek()
        {

        }
    }
}

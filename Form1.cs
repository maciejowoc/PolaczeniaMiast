using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PolaczeniaMiast
{
    public partial class Form1 : Form
    {
        readonly string NazwaPliku = null;
        bool ZmienionaNazwa = false;
        readonly Graf g;
        public Form1(string Nazwa)
        {
            InitializeComponent();
            NazwaPliku = Nazwa;
            try
            {
                System.IO.StreamReader plik = new StreamReader(NazwaPliku);
                g = new Graf(plik);            //Graf - mapa
                plik.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nie można odnaleźć pliku " + NazwaPliku, "Brak pliku!");
                Application.Exit();
                Environment.Exit(1);
            }
            ZaladujListe();             //Generacja alfabetycznie posortowanej listy rozwijanej z nazwami miast           
        }

        

        // V ____________________________WYPISYWANIE SĄSIADÓW DANEGO MIASTA________________________ V
        private void button1_Click(object sender, EventArgs e)
        {
            if (ZmienionaNazwa == false)
            {
                MessageBox.Show("Wybierz miasto!", "Błąd");
                return;
            }
            else
            {
                UstawTabele();                  //Wyczyszczenie tabeli

                int indeksTabeli = 0;
                int IdCelu;                 //Pomocnicza zmienna pobierająca id miasta celu
                int identyfikator = g.Zaladuj(NazwaMiasta.Text);
                for (int j = 0; j < 47; j++)
                {
                    if (g.SprawdzKrawedz(identyfikator, j))
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[indeksTabeli].Cells[0].Value = (g.wierzcholki[identyfikator].nazwa + " - " + g.wierzcholki[j].nazwa);
                        IdCelu = g.wierzcholki[identyfikator].polaczenia.IndexOf(g.wierzcholki[j].id);
                        dataGridView1.Rows[indeksTabeli].Cells[1].Value = (g.wierzcholki[identyfikator].dlugosc[IdCelu]);
                        indeksTabeli++;
                    }
                }
            }           
        }

        void UstawTabele()
        {
            dataGridView1.CancelEdit();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Połączenie";
            dataGridView1.Columns[1].HeaderText = "Punkty:";
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        List<string> PomocniczaLista = new List<string>();

        // V ___________________________________SZUKANIE TRASY I OKREŚLANIE DŁUGOŚCI_________________________________ V
        private void Losuj_Click(object sender, EventArgs e)
        {           
            Random rnd = new Random();
            bool warunek = false;               //Warunek sprawdzający czy wylosowane miasto jako meta nie koliduje z warunkami wyszukiwania
            int start;
            int meta;
            List<string> etapy;// = new List<string>();
            if (StacjaZListy.Checked == true)           //Jeśli zaznaczono startową stację to pobiera jej id z listy
            {
                if(ZmienionaNazwa==false)
                {
                    MessageBox.Show("Wybierz miasto!", "Błąd");
                    return;
                }
                else
                {
                    start = g.Zaladuj(NazwaMiasta.Text);
                }                
            }
            else                                        //Jeśli nie to losuje

            {
                start = rnd.Next(g.wierzcholki.Count);
            }
            UstawTabele();
            while (warunek != true)
            {
                meta = rnd.Next(g.wierzcholki.Count);
                if (!g.wierzcholki[start].SprawdzPolaczenie(meta) && start != meta)
                {
                    //Wypisanie wylosowanego połączenia
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = (g.wierzcholki[start].nazwa + " - " + g.wierzcholki[meta].nazwa);
                    //Wywołanie metody wyszukiwania drogi
                    etapy = g.Droga(start, meta);
                    PomocniczaLista = etapy;
                    dataGridView1.Rows[0].Cells[1].Value = (g.dlugosc.ToString());
                    warunek = true;
                }
            }
            NajkrotszaTrasa.Enabled = true;

        }

        void ZaladujListe()
        {
            string[] nazwy = new string[Convert.ToInt32(g.wierzcholki.Count)];
            for (int i = 0; i < g.wierzcholki.Count; i++)
            {
                nazwy[i] = g.wierzcholki[i].nazwa;
            }
            Array.Sort(nazwy);
            for (int i = 0; i < g.wierzcholki.Count; i++)
            {
                NazwaMiasta.Items.Add(nazwy[i]);
            }

        }

        private void NajkrotszaTrasa_Click(object sender, EventArgs e)
        {
            //Wypisanie poszczególnych miast
            for (int i = 0; i < PomocniczaLista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i + 1].Cells[0].Value = (PomocniczaLista[i]);
            }
            PomocniczaLista.Clear();
        }

        private void ZmienMape_Click(object sender, EventArgs e)
        {
            OknoWyboru menu = new OknoWyboru();
            this.Dispose();
            menu.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NazwaMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZmienionaNazwa = true;
        }
    }
}

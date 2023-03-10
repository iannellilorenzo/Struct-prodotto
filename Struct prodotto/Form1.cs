using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Struct_prodotto
{
    public partial class Form1 : Form
    {
        string path;
        public prodotto[] p; // p è il nome, prodotto è il datatype
        public int dim;

        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
            path = @"prodotti.csv";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public struct prodotto
        {
            public string nome;
            public float prezzo;
            public int quant;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region FunzioniServizio

        public string prodString(prodotto p)
        {
            if (p.quant == 0)
            {
                p.quant = 1;
            }

            return $"Nome: {p.nome}; Prezzo: €{p.prezzo}; Quantità: {p.quant}";
        }

        public void visualizza(prodotto[] pp)
        {
            listView.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView.Items.Add(prodString(p[i]));
            }
        }

        private void salva_Click_1(object sender, EventArgs e)
        {
            p[dim].nome = Nome.Text;
            p[dim].prezzo = float.Parse(Price.Text);
            p[dim].quant = int.Parse(Quant.Text);
            dim++;
            visualizza(p);
        }

        public int RicercaSQL()
        {
            int search = -1;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == Nome.Text)
                {
                    search = i;
                    break;
                }
            }

            return search;
        }

        public void Canc()
        {
            int indice = RicercaSQL();

            if (indice != -1)
            {
                for (int i = indice; i < dim - 1; i++)
                {
                    p[i] = p[i + 1];
                }

                dim--;
                listView.Clear();
                visualizza(p);
            }
            else
            {
                MessageBox.Show("Prodotto non trovato");
            }
        }

        public void Mod()
        {
            int indice = RicercaSQL();

            float prezzoNuovo = 0;
            if (indice != -1)
            {
                if (Modif.Text != "")
                {
                    p[indice].nome = Modif.Text;
                    visualizza(p);
                    MessageBox.Show("Nome del prodotto modificato");
                }
                else
                {
                    MessageBox.Show("Nome del prodotto non inserito");
                }

                if (ModifPrezzo.Text != "")
                {
                    prezzoNuovo = p[indice].prezzo + (p[indice].prezzo * float.Parse(ModifPrezzo.Text) / 100);
                    p[indice].prezzo = prezzoNuovo;
                    visualizza(p);
                    MessageBox.Show("Prezzo del prodotto modificato");
                }
                else
                {
                    MessageBox.Show("Prezzo del prodotto non inserito");
                }
            }
            else
            {
                MessageBox.Show("Non è stato possibile modificare il nome o il prezzo del prodotto");
            }
        }

        public float Totale()
        {
            float sum = 0;

            for (int i = 0; i < dim; i++)
            {
                sum += p[i].prezzo;
            }

            return sum;
        }

        public float Max()
        {
            float max = p[0].prezzo;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo > max)
                {
                    max = p[i].prezzo;
                }
            }

            return max;
        }

        public float Min()
        {
            float min = p[0].prezzo;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo < min)
                {
                    min = p[i].prezzo;
                }
            }

            return min;
        }

        #endregion FunzioniServizio

        #region FunzioniForm

        private void Cancellazione_Click(object sender, EventArgs e)
        {
            Canc();
        }

        private void ModificaNome_Click(object sender, EventArgs e)
        {
            Mod();
        }

        private void Massimo_Click(object sender, EventArgs e)
        {
            float max = Max();

            MessageBox.Show($"Il prezzo più alto è: €{max}");
        }

        private void Minimo_Click(object sender, EventArgs e)
        {
            float min = Min();

            MessageBox.Show($"Il prezzo più basso è: €{min}");
        }

        private void Somma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il costo totale è €" + Totale());
        }

        #endregion FunzioniForm

        #region GestioneFile

        private void SalvaFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, append: false))
            {
                for (int i = 0; i < dim; i++)
                {
                    sw.WriteLine($"{p[i].nome}; €{p[i].prezzo}");
                }
            }
            
        }

        private void AggiornaFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                for (int i = 0; i < dim; i++)
                {
                    sw.WriteLine($"{p[i].nome}; €{p[i].prezzo}");
                }
            }
        }

        private void ApriFile_Click(object sender, EventArgs e)
        {
            listView.Clear();
            if (!File.Exists(path))
            {
                MessageBox.Show("Il file non è stato creato");
            }
            else
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;

                    while ((s = sr.ReadLine()) != null)
                    {
                        listView.Items.Add(s);
                    }
                }
            }
        }

        private void EliminaFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        

        #endregion GestioneFile

        
    }
}

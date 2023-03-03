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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Struct_prodotto
{
    public partial class Form1 : Form
    {
        public int indice;
        public int search;
        string path;

        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
            search = 0;
            indice = RicercaSQL();
            path = @"prodotti.csv";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }

        public prodotto[] p; // p è il nome, prodotto è il datatype
        public int dim;

        public string prodString(prodotto p)
        {
            return "Nome: " + p.nome + " Prezzo: " + p.prezzo.ToString();
        }

        public void visualizza(prodotto[] pp)
        {
            listView.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView.Items.Add(prodString(p[i]));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salva_Click_1(object sender, EventArgs e)
        {
            p[dim].nome = Nome.Text;
            p[dim].prezzo = float.Parse(Price.Text);
            dim++;
            visualizza(p);
        }

        private void Cancellazione_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                p[indice].nome = "";

                for (int i = indice; i < dim - 1; i++)
                {
                    p[i] = p[i + 1];
                }

                dim--;

                visualizza(p);
            }
            else
            {
                MessageBox.Show("Prodotto non trovato");
            }
        }

        // funz no-UI
        public int RicercaSQL()
        {
            
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome.ToString() == Nome.Text)
                {
                    search = i;
                }
                else
                {
                    search = -1;
                }
            }

            return search;
        }

        private void ModificaNome_Click(object sender, EventArgs e)
        {
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

        private void Somma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il costo totale è €" + Totale());
        }

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
            using (StreamReader sr = File.OpenText(path))
            {
                string s;

                if (!File.Exists(path))
                {
                    MessageBox.Show("Il file non è stato creato");
                }
                else
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        listView.Items.Add(s);
                    }
                }
            }
        }
    }
}

﻿using System;
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

namespace Struct_prodotto
{
    public partial class Form1 : Form
    {
        public int indice;
        public int search;

        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
            search = 0;
            indice = RicercaSQL();
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

        public bool ModNome()
        {
            bool conferma = false;

            if (indice != -1)
            {
                conferma = true;
            }
            else
            {
                conferma = false;
            }

            return conferma;
        }

        private void ModificaNome_Click(object sender, EventArgs e)
        {
            bool conf = ModNome();

            if (conf)
            {
                //p[indice].nome.ToString() = Nome.Text;
                MessageBox.Show("Nome del prodotto modificato");
                visualizza(p);
            }
            else
            {
                MessageBox.Show("Non è stato possibile modificare il nome del prodotto");
            }
        }
    }
}

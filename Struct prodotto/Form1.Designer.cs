namespace Struct_prodotto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.salva = new System.Windows.Forms.Button();
            this.Cancellazione = new System.Windows.Forms.Button();
            this.ModificaNome = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Somma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ModifPrezzo = new System.Windows.Forms.TextBox();
            this.SalvaFile = new System.Windows.Forms.Button();
            this.AggiornaFile = new System.Windows.Forms.Button();
            this.ApriFile = new System.Windows.Forms.Button();
            this.EliminaFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Massimo = new System.Windows.Forms.Button();
            this.Minimo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Quant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(9, 23);
            this.Nome.Margin = new System.Windows.Forms.Padding(2);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(76, 20);
            this.Nome.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(99, 22);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(76, 20);
            this.Price.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(309, 11);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(280, 347);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // salva
            // 
            this.salva.Location = new System.Drawing.Point(11, 67);
            this.salva.Margin = new System.Windows.Forms.Padding(2);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(124, 25);
            this.salva.TabIndex = 5;
            this.salva.Text = "Aggiungi al carrello";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click_1);
            // 
            // Cancellazione
            // 
            this.Cancellazione.Location = new System.Drawing.Point(11, 97);
            this.Cancellazione.Margin = new System.Windows.Forms.Padding(2);
            this.Cancellazione.Name = "Cancellazione";
            this.Cancellazione.Size = new System.Drawing.Size(124, 21);
            this.Cancellazione.TabIndex = 6;
            this.Cancellazione.Text = "Elimina dal carrello";
            this.Cancellazione.UseVisualStyleBackColor = true;
            this.Cancellazione.Click += new System.EventHandler(this.Cancellazione_Click);
            // 
            // ModificaNome
            // 
            this.ModificaNome.Location = new System.Drawing.Point(11, 123);
            this.ModificaNome.Margin = new System.Windows.Forms.Padding(2);
            this.ModificaNome.Name = "ModificaNome";
            this.ModificaNome.Size = new System.Drawing.Size(124, 21);
            this.ModificaNome.TabIndex = 7;
            this.ModificaNome.Text = "Modifica prodotto";
            this.ModificaNome.UseVisualStyleBackColor = true;
            this.ModificaNome.Click += new System.EventHandler(this.ModificaNome_Click);
            // 
            // Modif
            // 
            this.Modif.Location = new System.Drawing.Point(30, 270);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(100, 20);
            this.Modif.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome modificato";
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(12, 150);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(123, 23);
            this.Somma.TabIndex = 10;
            this.Somma.Text = "Totale da pagare";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prezzo Modificato";
            // 
            // ModifPrezzo
            // 
            this.ModifPrezzo.Location = new System.Drawing.Point(148, 270);
            this.ModifPrezzo.Name = "ModifPrezzo";
            this.ModifPrezzo.Size = new System.Drawing.Size(100, 20);
            this.ModifPrezzo.TabIndex = 12;
            // 
            // SalvaFile
            // 
            this.SalvaFile.Location = new System.Drawing.Point(9, 331);
            this.SalvaFile.Margin = new System.Windows.Forms.Padding(2);
            this.SalvaFile.Name = "SalvaFile";
            this.SalvaFile.Size = new System.Drawing.Size(56, 27);
            this.SalvaFile.TabIndex = 13;
            this.SalvaFile.Text = "Salva ";
            this.SalvaFile.UseVisualStyleBackColor = true;
            this.SalvaFile.Click += new System.EventHandler(this.SalvaFile_Click);
            // 
            // AggiornaFile
            // 
            this.AggiornaFile.Location = new System.Drawing.Point(70, 331);
            this.AggiornaFile.Margin = new System.Windows.Forms.Padding(2);
            this.AggiornaFile.Name = "AggiornaFile";
            this.AggiornaFile.Size = new System.Drawing.Size(86, 27);
            this.AggiornaFile.TabIndex = 14;
            this.AggiornaFile.Text = "Aggiorna";
            this.AggiornaFile.UseVisualStyleBackColor = true;
            this.AggiornaFile.Click += new System.EventHandler(this.AggiornaFile_Click);
            // 
            // ApriFile
            // 
            this.ApriFile.Location = new System.Drawing.Point(160, 332);
            this.ApriFile.Margin = new System.Windows.Forms.Padding(2);
            this.ApriFile.Name = "ApriFile";
            this.ApriFile.Size = new System.Drawing.Size(56, 25);
            this.ApriFile.TabIndex = 15;
            this.ApriFile.Text = "Apri";
            this.ApriFile.UseVisualStyleBackColor = true;
            this.ApriFile.Click += new System.EventHandler(this.ApriFile_Click);
            // 
            // EliminaFile
            // 
            this.EliminaFile.Location = new System.Drawing.Point(220, 332);
            this.EliminaFile.Margin = new System.Windows.Forms.Padding(2);
            this.EliminaFile.Name = "EliminaFile";
            this.EliminaFile.Size = new System.Drawing.Size(56, 25);
            this.EliminaFile.TabIndex = 16;
            this.EliminaFile.Text = "Elimina";
            this.EliminaFile.UseVisualStyleBackColor = true;
            this.EliminaFile.Click += new System.EventHandler(this.EliminaFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gestione file";
            // 
            // Massimo
            // 
            this.Massimo.Location = new System.Drawing.Point(12, 180);
            this.Massimo.Name = "Massimo";
            this.Massimo.Size = new System.Drawing.Size(123, 23);
            this.Massimo.TabIndex = 18;
            this.Massimo.Text = "Prezzo più alto";
            this.Massimo.UseVisualStyleBackColor = true;
            this.Massimo.Click += new System.EventHandler(this.Massimo_Click);
            // 
            // Minimo
            // 
            this.Minimo.Location = new System.Drawing.Point(12, 210);
            this.Minimo.Name = "Minimo";
            this.Minimo.Size = new System.Drawing.Size(123, 23);
            this.Minimo.TabIndex = 19;
            this.Minimo.Text = "Prezzo più basso";
            this.Minimo.UseVisualStyleBackColor = true;
            this.Minimo.Click += new System.EventHandler(this.Minimo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quantità";
            // 
            // Quant
            // 
            this.Quant.Location = new System.Drawing.Point(192, 22);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(73, 20);
            this.Quant.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Minimo);
            this.Controls.Add(this.Massimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EliminaFile);
            this.Controls.Add(this.ApriFile);
            this.Controls.Add(this.AggiornaFile);
            this.Controls.Add(this.SalvaFile);
            this.Controls.Add(this.ModifPrezzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.ModificaNome);
            this.Controls.Add(this.Cancellazione);
            this.Controls.Add(this.salva);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Nome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Button Cancellazione;
        private System.Windows.Forms.Button ModificaNome;
        private System.Windows.Forms.TextBox Modif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModifPrezzo;
        private System.Windows.Forms.Button SalvaFile;
        private System.Windows.Forms.Button AggiornaFile;
        private System.Windows.Forms.Button ApriFile;
        private System.Windows.Forms.Button EliminaFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Massimo;
        private System.Windows.Forms.Button Minimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quant;
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casadei.Michele._4i.RubricaWPF
{
    class Contatto
    {
        //Attributi
        private int pk;
        private string nome;
        private string cognome;
        private string numero;
        private string indirizzo;
        private string mail;

        //Proprietà
        public int Pk { get => pk; set => pk = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public string Mail { get => mail; set => mail = value; }

        //Costruttori

        //Costruzione di un contatto tramite il file CSV
        public Contatto(string riga)
        {

            string[] campi = riga.Split(';');

            if (int.TryParse(campi[0], out int res) && campi.Length == 5)
            {
                this.pk = res;
                this.Nome = campi[1];
                this.Cognome = campi[2];
                this.numero = campi[3];
                this.mail = campi[4];
            }
            else
                this.pk = 0;



        }
        //Creazione di un contatto vuoto
        public Contatto()
        {
        }
    }
}
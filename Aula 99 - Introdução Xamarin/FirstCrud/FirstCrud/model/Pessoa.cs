using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace FirstCrud.model
{
    class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }

        public Pessoa(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public Pessoa(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
        }

        public Pessoa()
        {
        }

        public override string ToString()
        {
            return this.nome + " - " + this.email;
        }
    }
}
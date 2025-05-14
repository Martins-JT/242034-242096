using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _242034_242096.Models
{
    public  class Cliente
    {
        public int id { get; set; }

        public string nome { get; set; }

        public int idCidade { get; set; }

        public DateTime dataNasc {  get; set; }

        public double renda { get; set; }

        public string cpf { get; set; }

        public string foto { get; set; }

        public bool venda { get; set; }

       
    }
}

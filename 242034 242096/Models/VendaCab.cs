using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace _242034_242096.Models
{
    public class VendaCab
    {

        public int Id { get; set; }

        public int idcliente { get; set; }

        public DateTime data { get; set; }

        public double total { get; set; }

        
    }
}

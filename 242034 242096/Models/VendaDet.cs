using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace _242034_242096.Models
{
    public class VendaDet
    {
        public int Id { get; set; }

        public int idvendacab { get; set; }

        public int idproduto { get; set; }

        public double QTDE { get; set; }

        public double VLR_UNIT { get; set; }

    }
}

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



        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO vendas_cab(idvendacab, idproduto, QTDE, VRL_UNIT) " +
                    "VALUES (@idvendacab, @idproduto, @QTDE, @VRL_UNIT)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idvendacab", idvendacab);
                Banco.Comando.Parameters.AddWithValue("@idproduto", idproduto);
                Banco.Comando.Parameters.AddWithValue("@QTDE", QTDE);
                Banco.Comando.Parameters.AddWithValue("@VLR_UNIT", VLR_UNIT);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
        }




    }
}
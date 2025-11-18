using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace _242034_242096.Models
{
    public class VendaCab
    {

        public int Id { get; set; }

        public int id_cliente { get; set; }

        public DateTime data { get; set; }

        public double total { get; set; }


        public int Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO vendascab(id_cliente, data, total) " +
                    "VALUES (@idcliente, @data, @total)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idcliente", id_cliente);
                Banco.Comando.Parameters.AddWithValue("@data", data);
                Banco.Comando.Parameters.AddWithValue("@total", total);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

                return (int)Banco.Comando.LastInsertedId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }



        }
    }


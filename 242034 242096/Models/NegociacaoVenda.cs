using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _242034_242096.Models
{
    internal class NegociacaoVenda
    {
        public int id { get; set; }

        public int idVenda { get; set; }

        public byte parcela {  get; set; }

        public DateTime data_vencto { get; set; }

        public DateTime data_pagto { get; set; }

        public double vlr_parcela { get; set; }

        public Boolean status {  get; set; }

        public void Incluir()
        {
            try
            {
                //Abre a conexão com banco
                Banco.AbrirConexao();

                //Alimenta o método command com a instrução desejada e indicada a conexão utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO contas_receber (idVenda, parcela, data_vencto, " +
                    "vlr_parcela, status) " +
                    "VALUES (@idVenda, @parcela, @data_vencto, " +
                    "@vlr_parcela, @status)", Banco.Conexao);

                //Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@idVenda", idVenda);
                Banco.Comando.Parameters.AddWithValue("@parcela", parcela);
                Banco.Comando.Parameters.AddWithValue("@data_vencto", data_vencto);
                Banco.Comando.Parameters.AddWithValue("@vlr_parcela", vlr_parcela);
                Banco.Comando.Parameters.AddWithValue("@status", status);

                //Executa o comando, no MYSQL, tem a função do Raio do WorkBench
                Banco.Comando.ExecuteNonQuery();

                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

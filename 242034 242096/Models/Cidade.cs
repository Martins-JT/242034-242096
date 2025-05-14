using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _242034_242096.Models
{
    public class Cidade
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string uf { get; set; } // ===> get le os dados. set grava os dados.

        public void Incluir()
        {
            try
            {
                //Abre a conexão com o banco
                Banco.AbrirConexao();
                //Alimenta o método command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", Banco.Conexao);
                //Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@nome", nome); // Parâmetro string
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                //Executa o Comando, no MYSQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable Consultar()
        {
            try 
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Cidades where nome like @Nome " + "order by nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando); // OS DADOS SÃO INSERIDOS NO BANCO.MYSQL
                Banco.datTabela = new DataTable(); // OS DADOS SÃO SALVOS NO C#
                Banco.Adaptador.Fill(Banco.datTabela); // OS DADOS DO C# SÃO INSERIDOS NO DATAGRIDVIEW
                Banco.FecharConexao();
                return Banco.datTabela;

                /*
                 
                Comandos principais no MYsql:
                INSERT
                UPDATE
                DELETE

                 */
            } 
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Alterar()
        {
            try
            {
                //Abre a conexão com o banco
                Banco.AbrirConexao();
                //Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("Update cidades set nome = @nome, uf = @uf where id = @id", Banco.Conexao);
                //Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                //Executa o Comando, no MYSQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try 
            {
                //Abre a conexão com o banco
                Banco.AbrirConexao();

                //Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("delete from cidades where id = @id", Banco.Conexao);

                //Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@id", id);

                //Executa o Comando, no MYSQL, tem a função do Raio do Workbench
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

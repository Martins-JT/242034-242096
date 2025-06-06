using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using _242034_242096.Models;

namespace _242034_242096.Views
{
    public partial class FrmProdutos : Form
    {
        Produto p;
        Categorias cat;
        Marcas m;
        public FrmProdutos()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            txtId.Clear();
            cboCategorias.SelectedIndex = -1;
            cboMarcas.SelectedIndex = -1;
            txtValor.Clear();
            txtEstoque.Clear();
            txtDescricao.Clear();
            picFoto.ImageLocation = "";
            txtPesquisa.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            p = new Produto()

            {
                descricao = pesquisa
            };
            dgvProdutos.DataSource = p.Consultar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty) return;

            p = new Produto()
            {
              
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategorias.SelectedValue,
                idMarca = (int)cboMarcas.SelectedValue,
                valorVenda = double.Parse(txtValor.Text),
                estoque = double.Parse(txtEstoque.Text),
                
                
                foto = picFoto.ImageLocation

            };
            p.Incluir();

            limpaControles();
            carregarGrid("");

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            //Cria um objeto do tipo cidade
            //E alimenta o comboBox
            cat = new Categorias();
            cboCategorias.DataSource = cat.Consultar();
            cboCategorias.DisplayMember = "categoria"; // o que o usuário vê, no caso o nome da categoria.
            cboCategorias.ValueMember = "id"; // guarda o id 

            limpaControles();
            carregarGrid("");

            //Deixa invisível colunas do Grid
            dgvProdutos.Columns["idCategoria"].Visible = false;
            dgvProdutos.Columns["foto"].Visible = false;

            //MARCAS

            //Cria um objeto do tipo cidade
            //E alimenta o comboBox
            m = new Marcas();
            cboMarcas.DataSource = m.Consultar();
            cboMarcas.DisplayMember = "marca";
            cboMarcas.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            //Deixa invisível colunas do Grid
            dgvProdutos.Columns["idMarca"].Visible = false;
            dgvProdutos.Columns["foto"].Visible = false;




        }

      

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "X:/fotos/produtos/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == String.Empty) return;
            {
                p = new Produto()
                {
                    id = int.Parse(txtId.Text),
                    descricao = txtDescricao.Text,
                    idCategoria = (int)cboCategorias.SelectedValue,
                    idMarca = (int)cboMarcas.SelectedValue,
                    valorVenda = double.Parse(txtValor.Text),
                    estoque = double.Parse(txtEstoque.Text),
                    foto = picFoto.ImageLocation
                };
                p.Alterar();
                limpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            {
                if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    p = new Produto()
                    {
                        id = int.Parse(txtId.Text),

                    };
                    p.Excluir();
                    limpaControles();
                    carregarGrid("");
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
            txtDescricao.Text = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
            cboCategorias.Text = dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
            cboMarcas.Text = dgvProdutos.CurrentRow.Cells["marca"].Value.ToString();
            txtValor.Text = dgvProdutos.CurrentRow.Cells["valorVenda"].Value.ToString();
            txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
            picFoto.ImageLocation = dgvProdutos.CurrentRow.Cells["foto"].Value.ToString();
        }
    }
}

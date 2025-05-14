using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _242034_242096.Models;

namespace _242034_242096.Views
{
    public partial class FrmCategorias : Form
    {
        Categorias ct;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();

        }
        void carregarGrid(string pesquisa)
        {
            ct = new Categorias()

            {
                categoria = pesquisa
            };
            dgvCategorias.DataSource = ct.Consultar();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            
            ct = new Categorias()
            {
               categoria = txtNome.Text,

            };
            ct.Incluir();

            limpaControles();
            carregarGrid("");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            {
                if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ct = new Categorias()
                    {
                        id = int.Parse(txtID.Text),

                    };
                    ct.Excluir();
                    limpaControles();
                    carregarGrid("");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

    

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;
            {
                ct = new Categorias()
                {
                    id = int.Parse(txtID.Text),
                    categoria = txtNome.Text,

                };
                ct.Alterar();
                limpaControles();
                carregarGrid("");
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                txtID.Text = dgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();

            }
        }
    }
}

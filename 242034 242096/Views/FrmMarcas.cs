using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using _242034_242096.Models;

namespace _242034_242096.Views
{
    public partial class FrmMarcas : Form
    {  Marcas m;
        public FrmMarcas()
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
            m = new Marcas()

            {
                marca = pesquisa
            };
            dgvMarcas.DataSource = m.Consultar();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            m = new Marcas()
            {
                marca = txtNome.Text,
                
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;
            {
                m = new Marcas()
                {
                    id = int.Parse(txtID.Text),
                    marca = txtNome.Text,
                    
                };
                m.Alterar();
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
            if (txtID.Text == "") return;
            {
                if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m = new Marcas()
                    {
                        id = int.Parse(txtID.Text),

                    };
                    m.Excluir();
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

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            
            limpaControles();
            carregarGrid("");
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.RowCount > 0)
            {
                txtID.Text = dgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvMarcas.CurrentRow.Cells["marca"].Value.ToString();

            }
        }
    }
}

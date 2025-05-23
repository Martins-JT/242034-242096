using System;
using System.Data;
using System.Windows.Forms;
using _242034_242096.Models;

namespace _242034_242096.Views
{
    public partial class FrmClientes : Form
    {
        Cliente cl;
        Cidade ci;
        public FrmClientes()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
            txtPesquisa.Clear();

        }
        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()

            {
                nome = pesquisa
            };
            dgvClientes.DataSource = cl.Consultar();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            cl = new Cliente()
            {
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                cpf = mskCPF.Text,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                venda = chkVenda.Checked,
                foto = picFoto.ImageLocation

            };
            cl.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == String.Empty) return;
            {
                cl = new Cliente()
                {
                    id = int.Parse(txtId.Text),
                    nome = txtNome.Text,
                    idCidade = (int)cboCidades.SelectedValue,
                    cpf = mskCPF.Text,
                    dataNasc = dtpDataNasc.Value,
                    renda = double.Parse(txtRenda.Text),
                    venda = chkVenda.Checked,
                    foto = picFoto.ImageLocation
                };
                cl.Alterar();
                limpaControles();
                carregarGrid("");
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Cria um objeto do tipo cidade
            //E alimenta o comboBox
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            //Deixa invisível colunas do Grid
            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;

        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvClientes.CurrentRow.Cells["id"].Value.ToString();
            txtNome.Text = dgvClientes.CurrentRow.Cells["nome"].Value.ToString();
            cboCidades.Text = dgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
            mskCPF.Text = dgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
            dtpDataNasc.Text = dgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
            txtRenda.Text = dgvClientes.CurrentRow.Cells["renda"].Value.ToString();
            picFoto.ImageLocation = dgvClientes.CurrentRow.Cells["foto"].Value.ToString();
            chkVenda.Checked = (bool)dgvClientes.CurrentRow.Cells["venda"].Value;
            txtUF.Text = dgvClientes.CurrentRow.Cells["uf"].Value.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;
            {
                if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cl = new Cliente()
                    {
                        id = int.Parse(txtId.Text),

                    };
                    cl.Excluir();
                    limpaControles();
                    carregarGrid("");
                }
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "X:/fotos/clientes/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }
    }
}

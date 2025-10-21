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
    public partial class FrmContasaReceber : Form
    {
        Cliente c;
        NegociacaoVenda nv;
        public FrmContasaReceber()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboClientes.SelectedItem;
                txtCPF.Text = reg["CPF"].ToString();
            } 
        }

        private void FrmContasaReceber_Load(object sender, EventArgs e)
        {
            c = new Cliente();
            cboClientes.DataSource = c.Consultar();
            cboClientes.DisplayMember = "nome";
            cboClientes.ValueMember = "id";
            cboClientes.ResetText();
        }

        void carregarGrid(int idCliente)
        {
            nv = new NegociacaoVenda()

            {
                idCliente = idCliente
            };
            dgvContas_receber.DataSource = nv.Consultar(idCliente);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex != -1)
            {
                NegociacaoVenda n = new NegociacaoVenda();
                dgvContas_receber.DataSource = n.Consultar((int)cboClientes.SelectedValue);
                
            }
            else
            {
                MessageBox.Show("Nenhum Cliente selecionado! ", "Contas a Receber", MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
            }
        }
    }
}

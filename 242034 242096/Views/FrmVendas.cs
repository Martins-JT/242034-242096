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
    public partial class FrmVendas : Form
    {
        double total;
        Cliente c;
        Produto p;
        VendaCab vc;
        VendaDet vd;

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboClientes.SelectedItem;
                txtCidade.Text = reg["CIDADE"].ToString();
                txtUF.Text = reg["UF"].ToString();
                txtRenda.Text = reg["RENDA"].ToString();
                mskCPF.Text = reg["CPF"].ToString();
                mskDataNasc.Text = reg["DATANASC"].ToString();
                picCliente.Text = reg["FOTO"].ToString();
                chkVenda.Checked = (bool)reg["venda"];

            }
        }
        void limpaProduto()
        {
            cboProdutos.SelectedIndex = -1;
            txtEstoque.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtCategoria.Clear();
            txtMarca.Clear();
            picProduto.ImageLocation = "";     
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex == -1) 
            {
                if (chkVenda.Checked) 
                {
                    MessageBox.Show("Cliente bloqueado para a venda", "vendas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar.PerformClick();
                    return;
                }
                grbClientes.Enabled = false;
                grbProdutos.Enabled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProdutos.RowCount = 0;
            cboClientes.SelectedIndex = -1;
            txtCidade.Clear();
            txtRenda.Clear();
            txtUF.Clear();
            mskCPF.Clear();
            mskDataNasc.Value = DateTime.Now;
            chkVenda.Checked = false;
            picCliente.ImageLocation = "";
            total = 0;
            lblTotal.Text = total.ToString("c");
            grbClientes.Enabled = true;
            grbProdutos.Enabled = false;
            limpaProduto();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            c = new Cliente();
            

            cboClientes.DataSource = c.Consultar();
            cboClientes.DataSource = "nome";
            cboClientes.DataSource = "id";


            p = new Produto();
            cboProdutos.DataSource = p.Consultar();
            cboProdutos.DataSource = "descricao";
            cboProdutos.DataSource = "id";

            btnCancelar.PerformClick();

        }
    }
}

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
using Google.Protobuf.WellKnownTypes;

namespace _242034_242096.Views
{
    public partial class FrmContasaReceber : Form
    {
        double total = 0;
        
        NegociacaoVenda nv;
        public FrmContasaReceber()
        {
            InitializeComponent();
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvContas_receber.DataSource = DBNull.Value;
        }

        private void FrmContasaReceber_Load(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            cboClientes.DataSource = c.Consultar();
            cboClientes.DisplayMember = "nome";
            cboClientes.ValueMember = "id";
            //cboClientes.ResetText();
            txtData.Text = DateTime.Now.ToShortDateString();


            cboCPFs.DataSource = cboClientes.DataSource;

            cboCPFs.DisplayMember = "cpf";
            cboCPFs.ValueMember = "id";

            LimparForm();
        }

        private void LimparForm()
        {
            cboClientes.SelectedIndex = -1;
            cboCPFs.SelectedIndex = -1;

            total = 0;
            lblTotal.Text = total.ToString("C");

            txtData.Text = DateTime.Now.ToShortDateString();

            dgvContas_receber.DataSource = "";

            cboCPFs.Select();

            btnConfirmar.Enabled = false;
            btnMarcar.Enabled = false;
            btnDesmarcar.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
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
                total = 0;
                lblTotal.Text = total.ToString("C");
                
            }
            else
            {
                MessageBox.Show("Nenhum Cliente selecionado! ", "Contas a Receber", MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
            }
        }

        
     

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            total = 0;

            foreach(DataGridViewRow linha in dgvContas_receber.Rows)
            {
                linha.Cells["status"].Value = true;
                total += (double)linha.Cells["vlr_parcela"].Value;
            }
            lblTotal.Text = total.ToString("C");
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            total = 0;

            foreach (DataGridViewRow linha in dgvContas_receber.Rows)
            {
                linha.Cells["status"].Value = false;
            }

            lblTotal.Text = total.ToString("C");
        }

        private void dgvContas_receber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                if (!(bool)dgvContas_receber.CurrentRow.Cells["status"].Value)
                {
                    dgvContas_receber.CurrentRow.Cells["status"].Value = true;
                    total += (double)dgvContas_receber.CurrentRow.Cells["vlr_parcela"].Value;
                }
                else
                {
                    dgvContas_receber.CurrentRow.Cells["status"].Value = false;
                    total -= (double)dgvContas_receber.CurrentRow.Cells["vlr_parcela"].Value;
                }
                lblTotal.Text = total.ToString("C");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in dgvContas_receber.Rows)
            {
                if ((bool)linha.Cells["status"].Value)
                {
                    NegociacaoVenda n = new NegociacaoVenda
                    {
                        idVenda = (int)linha.Cells["idVenda"].Value,
                        parcela = Convert.ToByte(linha.Cells["parcela"].Value),
                        data_pagto = DateTime.Now
                    };
                    n.BaixarParcela();

                   
                }
            }
            FrmCaixa frm = new FrmCaixa(0, (int)cboClientes.SelectedValue, total, cboClientes.Text);
            frm.ShowDialog();
        }
    }
}

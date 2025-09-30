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

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtCPF.Text != "")
            {
               
            }
        }

        
    }
}

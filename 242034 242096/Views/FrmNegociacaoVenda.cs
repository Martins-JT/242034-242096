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
    public partial class FrmNegociacaoVenda : Form
    {
        // total e parcela receberão um valor enviado pelo usuário, já a variável entrada se o usuário não fornecesse um valor
        // seria nulo e daria erro, ou seja, quando você atribui o 0 evita erros como o nulo e mantém a fluidez do código.
        double total, entrada = 0, parcela;

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            calcularParcela();
        }

        private void nudQtdeParcela_ValueChanged(object sender, EventArgs e)
        {
            calcularParcela();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            for (byte NumPar = 0; NumPar < nudQtdeParcela.Value; NumPar++)
            {
                NegociacaoVenda n = new NegociacaoVenda()
                {
                    idVenda = Convert.ToInt16(txtIdVenda.Text),
                    parcela = Convert.ToByte(NumPar + 1),
                    data_vencto = dtpVencto.Value.AddMonths(NumPar),
                    vlr_parcela = parcela,
                    status = false
                };

                n.Incluir();
            }
            Close();
            if (entrada > 0)
            {
                FrmCaixa frm = new FrmCaixa(int.Parse(txtIdVenda.Text), int.Parse(txtidCliente.Text), entrada, txtNome.Text);
                frm.ShowDialog();
            }
        }

       

        public FrmNegociacaoVenda(int idVenda, int idCliente,double total, string nome)
            //esse é um método que constroi o form
        {
            InitializeComponent();

            txtIdVenda.Text = idVenda.ToString();
            txtidCliente.Text = idCliente.ToString();
            txtNome.Text = nome;
            txtTotal.Text = total.ToString("c");
            txtData.Text = DateTime.Now.ToShortDateString();
            dtpVencto.Value = DateTime.Now.AddMonths(1);
            this.total = total;

            calcularParcela();

           
        }
        void calcularParcela()
        {
            double saldo = total - entrada;
            if (txtEntrada.Text != "") entrada = double.Parse(txtEntrada.Text);

            parcela = saldo / Convert.ToByte(nudQtdeParcela.Value);

            lblSaldo.Text = saldo.ToString("C");

            lblVlrParcela.Text = parcela.ToString("C");
            }
    }
}

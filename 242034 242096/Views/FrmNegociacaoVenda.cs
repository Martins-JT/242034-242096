using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _242034_242096.Views
{
    public partial class FrmNegociacaoVenda : Form
    {
        // total e parcela receberão um valor enviado pelo usuário, já a variável entrada se o usuário não fornecesse um valor
        // seria nulo e daria erro, ou seja, quando você atribui o 0 evita erros como o nulo e mantém a fluidez do código.
        double total, entrada = 0, parcela;
        public FrmNegociacaoVenda(int idVenda, int idCliente,double total, string nome)
            //esse é um método que constroi o form
        {
            InitializeComponent();

            txtidVenda.Text = idVenda.ToString();
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

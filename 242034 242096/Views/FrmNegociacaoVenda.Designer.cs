namespace _242034_242096.Views
{
    partial class FrmNegociacaoVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Parcelasaa = new System.Windows.Forms.GroupBox();
            this.lblVlrParcela = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpVencto = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQtdeParcela = new System.Windows.Forms.NumericUpDown();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Parcelasaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeParcela)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtidCliente);
            this.groupBox1.Controls.Add(this.txtIdVenda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(230, 24);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(81, 20);
            this.txtData.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(407, 22);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(115, 25);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "R$ 0,00";
            this.txtTotal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(432, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Enabled = false;
            this.txtidCliente.Location = new System.Drawing.Point(54, 52);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(50, 20);
            this.txtidCliente.TabIndex = 2;
            this.txtidCliente.Text = "0";
            this.txtidCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Enabled = false;
            this.txtIdVenda.Location = new System.Drawing.Point(54, 26);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(50, 20);
            this.txtIdVenda.TabIndex = 1;
            this.txtIdVenda.Text = "0";
            this.txtIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSaldo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEntrada);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(97, 54);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(117, 42);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "R$ 0,00";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saldo a Pagar:";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(77, 29);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 2;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Entrada:";
            // 
            // Parcelasaa
            // 
            this.Parcelasaa.Controls.Add(this.lblVlrParcela);
            this.Parcelasaa.Controls.Add(this.label9);
            this.Parcelasaa.Controls.Add(this.dtpVencto);
            this.Parcelasaa.Controls.Add(this.label8);
            this.Parcelasaa.Controls.Add(this.label7);
            this.Parcelasaa.Controls.Add(this.nudQtdeParcela);
            this.Parcelasaa.Location = new System.Drawing.Point(318, 121);
            this.Parcelasaa.Name = "Parcelasaa";
            this.Parcelasaa.Size = new System.Drawing.Size(299, 120);
            this.Parcelasaa.TabIndex = 2;
            this.Parcelasaa.TabStop = false;
            this.Parcelasaa.Text = "Parcelas";
            // 
            // lblVlrParcela
            // 
            this.lblVlrParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrParcela.Location = new System.Drawing.Point(171, 17);
            this.lblVlrParcela.Name = "lblVlrParcela";
            this.lblVlrParcela.Size = new System.Drawing.Size(117, 42);
            this.lblVlrParcela.TabIndex = 8;
            this.lblVlrParcela.Text = "R$ 0,00";
            this.lblVlrParcela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Valor:";
            // 
            // dtpVencto
            // 
            this.dtpVencto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencto.Location = new System.Drawing.Point(103, 69);
            this.dtpVencto.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpVencto.Name = "dtpVencto";
            this.dtpVencto.Size = new System.Drawing.Size(89, 20);
            this.dtpVencto.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pagto. da Primeira";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Qtde:";
            // 
            // nudQtdeParcela
            // 
            this.nudQtdeParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdeParcela.Location = new System.Drawing.Point(42, 29);
            this.nudQtdeParcela.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudQtdeParcela.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdeParcela.Name = "nudQtdeParcela";
            this.nudQtdeParcela.Size = new System.Drawing.Size(51, 21);
            this.nudQtdeParcela.TabIndex = 0;
            this.nudQtdeParcela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdeParcela.ValueChanged += new System.EventHandler(this.nudQtdeParcela_ValueChanged);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.Color.LightGray;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Image = global::_242034_242096.Properties.Resources.GerarFinanceiro;
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(471, 264);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(159, 56);
            this.btnFinanceiro.TabIndex = 3;
            this.btnFinanceiro.Text = "Gerar Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // FrmNegociacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 321);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.Parcelasaa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNegociacaoVenda";
            this.Text = "Negociação de Venda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Parcelasaa.ResumeLayout(false);
            this.Parcelasaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeParcela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Parcelasaa;
        private System.Windows.Forms.Label lblVlrParcela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpVencto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQtdeParcela;
        private System.Windows.Forms.Button btnFinanceiro;
    }
}
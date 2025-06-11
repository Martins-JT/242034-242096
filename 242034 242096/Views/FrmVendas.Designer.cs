namespace _242034_242096.Views
{
    partial class FrmVendas
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
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbClientes
            // 
            this.grbClientes.Controls.Add(this.btnConfirmar);
            this.grbClientes.Controls.Add(this.picCliente);
            this.grbClientes.Controls.Add(this.chkVenda);
            this.grbClientes.Controls.Add(this.txtRenda);
            this.grbClientes.Controls.Add(this.label5);
            this.grbClientes.Controls.Add(this.mskCPF);
            this.grbClientes.Controls.Add(this.label4);
            this.grbClientes.Controls.Add(this.mskDataNasc);
            this.grbClientes.Controls.Add(this.label3);
            this.grbClientes.Controls.Add(this.txtUF);
            this.grbClientes.Controls.Add(this.txtCidade);
            this.grbClientes.Controls.Add(this.label2);
            this.grbClientes.Controls.Add(this.label1);
            this.grbClientes.Controls.Add(this.cboClientes);
            this.grbClientes.Location = new System.Drawing.Point(12, 12);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Size = new System.Drawing.Size(776, 163);
            this.grbClientes.TabIndex = 0;
            this.grbClientes.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(503, 111);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 38);
            this.btnConfirmar.TabIndex = 47;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // picCliente
            // 
            this.picCliente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCliente.Location = new System.Drawing.Point(630, 9);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(140, 140);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCliente.TabIndex = 46;
            this.picCliente.TabStop = false;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(94, 115);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(115, 17);
            this.chkVenda.TabIndex = 35;
            this.chkVenda.Text = "Bloqueia a venda?";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(470, 75);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(92, 20);
            this.txtRenda.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Renda:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(248, 75);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(148, 20);
            this.mskCPF.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskDataNasc.Location = new System.Drawing.Point(94, 75);
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(97, 20);
            this.mskDataNasc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nascimento:";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(428, 44);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(49, 20);
            this.txtUF.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(60, 44);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(362, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(60, 14);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(362, 21);
            this.cboClientes.TabIndex = 0;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(92, 15);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(376, 21);
            this.cboProdutos.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Produto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(92, 43);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(376, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preço:";
            // 
            // picProduto
            // 
            this.picProduto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProduto.Location = new System.Drawing.Point(630, 9);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(140, 140);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 46;
            this.picProduto.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(491, 13);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(107, 56);
            this.btnInserir.TabIndex = 47;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(92, 74);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(376, 20);
            this.txtCategoria.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(92, 103);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(77, 20);
            this.txtQuantidade.TabIndex = 51;
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.btnRemover);
            this.grbProdutos.Controls.Add(this.txtEstoque);
            this.grbProdutos.Controls.Add(this.label7);
            this.grbProdutos.Controls.Add(this.txtPreco);
            this.grbProdutos.Controls.Add(this.txtQuantidade);
            this.grbProdutos.Controls.Add(this.label12);
            this.grbProdutos.Controls.Add(this.txtCategoria);
            this.grbProdutos.Controls.Add(this.label11);
            this.grbProdutos.Controls.Add(this.btnInserir);
            this.grbProdutos.Controls.Add(this.picProduto);
            this.grbProdutos.Controls.Add(this.label6);
            this.grbProdutos.Controls.Add(this.txtMarca);
            this.grbProdutos.Controls.Add(this.label9);
            this.grbProdutos.Controls.Add(this.label10);
            this.grbProdutos.Controls.Add(this.cboProdutos);
            this.grbProdutos.Location = new System.Drawing.Point(12, 181);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(776, 165);
            this.grbProdutos.TabIndex = 48;
            this.grbProdutos.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(491, 75);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(107, 56);
            this.btnRemover.TabIndex = 55;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(374, 105);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(94, 20);
            this.txtEstoque.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Estoque:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(218, 104);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(94, 20);
            this.txtPreco.TabIndex = 52;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PRODUTO,
            this.QTDE,
            this.VALOR});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 352);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(776, 156);
            this.dgvProdutos.TabIndex = 49;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            // 
            // QTDE
            // 
            this.QTDE.HeaderText = "QTDE";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(68, 522);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 27);
            this.lblTotal.TabIndex = 57;
            this.lblTotal.Text = "0,00";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(482, 517);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(95, 38);
            this.btnGravar.TabIndex = 58;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(583, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 38);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(684, 517);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(95, 38);
            this.btnFechar.TabIndex = 60;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbProdutos);
            this.Controls.Add(this.grbClientes);
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.DateTimePicker mskDataNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
    }
}
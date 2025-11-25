namespace _242034_242096.Views
{
    partial class FrmContasaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasaReceber));
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.cboCPFs = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.labe11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.dgvContas_receber = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grbClientes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas_receber)).BeginInit();
            this.SuspendLayout();
            // 
            // grbClientes
            // 
            this.grbClientes.BackColor = System.Drawing.Color.Transparent;
            this.grbClientes.Controls.Add(this.cboCPFs);
            this.grbClientes.Controls.Add(this.btnConfirmar);
            this.grbClientes.Controls.Add(this.label2);
            this.grbClientes.Controls.Add(this.label1);
            this.grbClientes.Controls.Add(this.cboClientes);
            this.grbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClientes.Location = new System.Drawing.Point(47, 12);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Size = new System.Drawing.Size(524, 147);
            this.grbClientes.TabIndex = 0;
            this.grbClientes.TabStop = false;
            this.grbClientes.Text = "Cliente";
            // 
            // cboCPFs
            // 
            this.cboCPFs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCPFs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCPFs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboCPFs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCPFs.FormattingEnabled = true;
            this.cboCPFs.IntegralHeight = false;
            this.cboCPFs.Location = new System.Drawing.Point(69, 22);
            this.cboCPFs.Name = "cboCPFs";
            this.cboCPFs.Size = new System.Drawing.Size(220, 21);
            this.cboCPFs.TabIndex = 6;
            this.cboCPFs.SelectedIndexChanged += new System.EventHandler(this.cboCPFs_SelectedIndexChanged);
            this.cboCPFs.TextChanged += new System.EventHandler(this.cboCPFs_TextChanged);
            this.cboCPFs.Validated += new System.EventHandler(this.cboCPFs_Validated);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(430, 78);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnConfirmar.Size = new System.Drawing.Size(88, 63);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Carregar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(69, 57);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(220, 24);
            this.cboClientes.TabIndex = 0;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            this.cboClientes.Validated += new System.EventHandler(this.cboClientes_Validated);
            // 
            // labe11
            // 
            this.labe11.AutoSize = true;
            this.labe11.BackColor = System.Drawing.Color.Transparent;
            this.labe11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe11.Location = new System.Drawing.Point(7, 20);
            this.labe11.Name = "labe11";
            this.labe11.Size = new System.Drawing.Size(44, 20);
            this.labe11.TabIndex = 4;
            this.labe11.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(79, 180);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 19);
            this.lblTotal.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.btnMarcar);
            this.groupBox3.Controls.Add(this.labe11);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnDesmarcar);
            this.groupBox3.Location = new System.Drawing.Point(47, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 214);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.Navy;
            this.txtData.Location = new System.Drawing.Point(55, 18);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 26);
            this.txtData.TabIndex = 6;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.Image = global::_242034_242096.Properties.Resources.Selecionar_Tudo;
            this.btnMarcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcar.Location = new System.Drawing.Point(6, 52);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Padding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.btnMarcar.Size = new System.Drawing.Size(194, 46);
            this.btnMarcar.TabIndex = 4;
            this.btnMarcar.Text = "Selecionar Tudo";
            this.btnMarcar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcar.Image = global::_242034_242096.Properties.Resources.Deselecionar_Tudo1;
            this.btnDesmarcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesmarcar.Location = new System.Drawing.Point(6, 105);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Padding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDesmarcar.Size = new System.Drawing.Size(194, 46);
            this.btnDesmarcar.TabIndex = 5;
            this.btnDesmarcar.Text = "Deselecionar Tudo";
            this.btnDesmarcar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesmarcar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // dgvContas_receber
            // 
            this.dgvContas_receber.AllowUserToAddRows = false;
            this.dgvContas_receber.AllowUserToDeleteRows = false;
            this.dgvContas_receber.AllowUserToOrderColumns = true;
            this.dgvContas_receber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas_receber.Location = new System.Drawing.Point(259, 181);
            this.dgvContas_receber.Name = "dgvContas_receber";
            this.dgvContas_receber.ReadOnly = true;
            this.dgvContas_receber.Size = new System.Drawing.Size(312, 161);
            this.dgvContas_receber.TabIndex = 1;
            this.dgvContas_receber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_receber_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = global::_242034_242096.Properties.Resources.shutdown;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(488, 348);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 40);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::_242034_242096.Properties.Resources.remove;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(372, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = global::_242034_242096.Properties.Resources.accept;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.Location = new System.Drawing.Point(259, 348);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(83, 40);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FrmContasaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 396);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dgvContas_receber);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbClientes);
            this.Name = "FrmContasaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContasaReceber";
            this.Load += new System.EventHandler(this.FrmContasaReceber_Load);
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas_receber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labe11;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dgvContas_receber;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ComboBox cboCPFs;
    }
}
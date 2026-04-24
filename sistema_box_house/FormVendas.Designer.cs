namespace sistema_box_house
{
    partial class FormVendas
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
            this.cbSelecionarProdutos = new System.Windows.Forms.ComboBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAddProdutos = new System.Windows.Forms.Button();
            this.dgvProdutosAdicionados = new System.Windows.Forms.DataGridView();
            this.lbValorTexto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbSelecionarProdutos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lbValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAdicionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelecionarProdutos
            // 
            this.cbSelecionarProdutos.FormattingEnabled = true;
            this.cbSelecionarProdutos.Location = new System.Drawing.Point(108, 14);
            this.cbSelecionarProdutos.Name = "cbSelecionarProdutos";
            this.cbSelecionarProdutos.Size = new System.Drawing.Size(310, 21);
            this.cbSelecionarProdutos.TabIndex = 0;
            this.cbSelecionarProdutos.SelectedIndexChanged += new System.EventHandler(this.cbSelecionarProdutos_SelectedIndexChanged);
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(108, 41);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(310, 20);
            this.numQuantidade.TabIndex = 1;
            // 
            // btnAddProdutos
            // 
            this.btnAddProdutos.Location = new System.Drawing.Point(591, 71);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(133, 23);
            this.btnAddProdutos.TabIndex = 2;
            this.btnAddProdutos.Text = "Adicionar Itens";
            this.btnAddProdutos.UseVisualStyleBackColor = true;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click_1);
            // 
            // dgvProdutosAdicionados
            // 
            this.dgvProdutosAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosAdicionados.Location = new System.Drawing.Point(7, 24);
            this.dgvProdutosAdicionados.Name = "dgvProdutosAdicionados";
            this.dgvProdutosAdicionados.Size = new System.Drawing.Size(724, 150);
            this.dgvProdutosAdicionados.TabIndex = 3;
            // 
            // lbValorTexto
            // 
            this.lbValorTexto.AutoSize = true;
            this.lbValorTexto.Location = new System.Drawing.Point(23, 398);
            this.lbValorTexto.Name = "lbValorTexto";
            this.lbValorTexto.Size = new System.Drawing.Size(108, 13);
            this.lbValorTexto.TabIndex = 4;
            this.lbValorTexto.Text = "TOTAL DO PEDIDO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbQuantidade);
            this.groupBox1.Controls.Add(this.lbSelecionarProdutos);
            this.groupBox1.Controls.Add(this.cbSelecionarProdutos);
            this.groupBox1.Controls.Add(this.numQuantidade);
            this.groupBox1.Controls.Add(this.btnAddProdutos);
            this.groupBox1.Location = new System.Drawing.Point(26, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção do Produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(21, 41);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 4;
            this.lbQuantidade.Text = "Quantidade";
            this.lbQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSelecionarProdutos
            // 
            this.lbSelecionarProdutos.AutoSize = true;
            this.lbSelecionarProdutos.Location = new System.Drawing.Point(21, 17);
            this.lbSelecionarProdutos.Name = "lbSelecionarProdutos";
            this.lbSelecionarProdutos.Size = new System.Drawing.Size(44, 13);
            this.lbSelecionarProdutos.TabIndex = 3;
            this.lbSelecionarProdutos.Text = "Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProdutosAdicionados);
            this.groupBox2.Location = new System.Drawing.Point(26, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 186);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens do Pedido";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(617, 398);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(133, 23);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Location = new System.Drawing.Point(138, 398);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(45, 13);
            this.lbValorTotal.TabIndex = 8;
            this.lbValorTotal.Text = "R$ 0,00";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lbValorTexto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAdicionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelecionarProdutos;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnAddProdutos;
        private System.Windows.Forms.DataGridView dgvProdutosAdicionados;
        private System.Windows.Forms.Label lbValorTexto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbSelecionarProdutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lbValorTotal;
    }
}
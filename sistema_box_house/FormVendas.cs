using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_box_house
{
    public partial class FormVendas : Form
    {
        BindingList<Produtos> listaProdutos = new BindingList<Produtos>();
        BindingList<Produtos> inventarioProdutos = new BindingList<Produtos>();

        double valorTotal = 0;
        public FormVendas()
        {
            InitializeComponent();

            Produtos produto1 = new Produtos("Coleira Universal", 5.99, 1);
            Produtos produto2 = new Produtos("Ração", 38.59, 1);
            Produtos produto3 = new Produtos("Brinquedos", 10.25, 1);
            Produtos produto4 = new Produtos("Casinha de Cachorro", 49.90, 1);
            Produtos produto5 = new Produtos("Banho", 50, 1);
            Produtos produto6 = new Produtos("Tosa", 50, 1);


            inventarioProdutos.Add(produto1);
            inventarioProdutos.Add(produto2);
            inventarioProdutos.Add(produto3);
            inventarioProdutos.Add(produto4);
            inventarioProdutos.Add(produto5);
            inventarioProdutos.Add(produto6);

            dgvProdutosAdicionados.DataSource = listaProdutos;
        }

        private void fnLimparForms()
        {
            cbSelecionarProdutos.SelectedIndex = -1;
            numQuantidade.Value = 1;
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddProdutos_Click_1(object sender, EventArgs e)
        {
            string nomeProduto = cbSelecionarProdutos.Text;
            int qtdProduto = (int)numQuantidade.Value;

            if (nomeProduto != string.Empty && qtdProduto > 0)
            {
                var locProduto = inventarioProdutos.FirstOrDefault(p => p.NomeProduto == nomeProduto);
                double valorProduto = locProduto.ValorProduto;
                Produtos produtoAdicionado = new Produtos(nomeProduto, valorProduto, qtdProduto);

                listaProdutos.Add(produtoAdicionado);
                valorTotal = valorTotal + (valorProduto * qtdProduto);

                lbValorTotal.Text = $"R${valorTotal.ToString("F2")}";

                fnLimparForms();

                dgvProdutosAdicionados.Refresh();

                produtoAdicionado.fnMsgAddProduto();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso");
            }
        }

        private void cbSelecionarProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            this.DialogResult = DialogResult.Cancel;
        }
    }

}

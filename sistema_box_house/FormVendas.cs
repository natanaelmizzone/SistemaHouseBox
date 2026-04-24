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
        BindingList<Produtos> estoqueProdutos = new BindingList<Produtos>();

        double valorTotal = 0;
        public FormVendas()
        {
            InitializeComponent();

            Produtos prod1 = new Produtos("Coleira Universal", 5.99, 1);
            Produtos prod2 = new Produtos("Ração", 38.59, 1);
            Produtos prod3 = new Produtos("Brinquedos", 10.25, 1);
            Produtos prod4 = new Produtos("Casinha de Cachorro", 49.90, 1);
            Produtos prod5 = new Produtos("Banho", 50, 1);
            Produtos prod6 = new Produtos("Tosa", 50, 1);


            estoqueProdutos.Add(prod1);
            estoqueProdutos.Add(prod2);
            estoqueProdutos.Add(prod3);
            estoqueProdutos.Add(prod4);
            estoqueProdutos.Add(prod5);
            estoqueProdutos.Add(prod6);

            dgvProdutosAdicionados.DataSource = listaProdutos;

            cbSelecionarProdutos.Items.Add("Coleira Universal");
            cbSelecionarProdutos.Items.Add("Ração");
            cbSelecionarProdutos.Items.Add("Brinquedos");
            cbSelecionarProdutos.Items.Add("Casinha de Cachorro");
            cbSelecionarProdutos.Items.Add("Banho");
            cbSelecionarProdutos.Items.Add("Tosa");
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
                var campoProduto = estoqueProdutos.FirstOrDefault(p => p.NomeProduto == nomeProduto);
                double valorProduto = campoProduto.ValorProduto;
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

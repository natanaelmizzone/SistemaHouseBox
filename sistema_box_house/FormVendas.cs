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

            Produtos p1 = new Produtos("Coleira Universal", 5.99, 1);
            Produtos p2 = new Produtos("Ração", 38.59, 1);
            Produtos p3 = new Produtos("Brinquedos", 10.25, 1);
            Produtos p4 = new Produtos("Brinquedos", 10.25, 1);
            Produtos p5 = new Produtos("Brinquedos", 10.25, 1);
            Produtos p6 = new Produtos("Brinquedos", 10.25, 1);


            inventarioProdutos.Add(p1);
            inventarioProdutos.Add(p2);
            inventarioProdutos.Add(p3);
            inventarioProdutos.Add(p4);
            inventarioProdutos.Add(p5);
            inventarioProdutos.Add(p6);

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
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }

        private void cbSelecionarProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

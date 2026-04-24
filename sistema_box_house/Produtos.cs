using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_box_house
{
    public class Produtos
    {
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public int QtdProduto { get; set; }

        public Produtos(string nomeProduto, double valorProduto, int qtdProduto)
        {
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
            QtdProduto = qtdProduto;
        }

        public void fnMsgAddProduto()
        {
            if (QtdProduto == 1)
            {
                MessageBox.Show($"O produto '{NomeProduto}' foi adicionado.", "Aviso");
            }
            else
            {
                MessageBox.Show($"O produto '{NomeProduto}' foi adicionado.", "Aviso");
            }
        }
    }
}



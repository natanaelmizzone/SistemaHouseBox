using System;

namespace sistema_box_house

{
	public class Cliente
	{
		public string NomeCliente (get; set;)
		public int PhoneTelefone(get; set;)
		public string NomePet(get; set;)

		public Cliente(string nomeCliente, int telefone, string nomePet)
		{
			NomeCliente = nomeCliente;
			PhoneTelefone = telefone;
			NomePet = nomePet;

		}
		public void fnMsgAddCliente()
		{

		}
		
	}
}

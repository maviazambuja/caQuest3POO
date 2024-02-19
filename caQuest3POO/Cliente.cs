using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuest3POO
{
    internal class Cliente
    {
        string nome_cliente;
        string endereco;
        string telefone;


        public Cliente() 
        {
            nome_cliente = string.Empty;
            endereco = string.Empty;
            telefone = string.Empty;
        }

        public Cliente(string _nome_cliente, string _endereco, string _telefone) 
        {
            nome_cliente = _nome_cliente;
            endereco = _endereco;
            telefone = _telefone;
        
        }

        public void AdicionaCliente(Cliente l)
        {
            listacliente[cont_cliente] = l;
            cont_cliente++;

        }






        //getters e setters
        public string Nome { get => nome; set => nome = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}

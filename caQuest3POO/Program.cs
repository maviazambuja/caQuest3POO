using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuest3POO
{
    internal class Program
    {
        public static void imprimeListaCliente(Cliente[] arrayCliente, int contCliente)
        {
            Console.WriteLine("= = = RELATÓRIO CLIENTES = = =");
            for (int i = 0; i < contCliente; i++)
            {
                Console.WriteLine("Nome do Aluno = " + arrayCliente[i].Nome);
                Console.WriteLine("Número de Matrícula = " + arrayCliente[i].Endereço);
                Console.WriteLine("Período = " + arrayCliente[i].Telefone);
            }
        }

        static void Main(string[] args)
        {
            Locadora[] arrayLocadora = new Locadora[100];
            Emprestimo[] arrayEmprestimo = new Emprestimo[100]; // array para armazenar 100 alunos
            Cliente[] arrayCliente = new Cliente[100]; // array para armazenar 100 materias

            int contLocadora = 0;
            int contEmprestimo = 0;
            int contCliente = 0;

            int aux = 1;
            while (aux != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] CADASTRAR UM CARRO");
                Console.WriteLine(" [2] CADASTRAR UM CLIENTE");
                Console.WriteLine(" [3] CADASTRAR UM EMPRESTIMO");
                Console.WriteLine(" [4] RELATORIO EMPRESTIMO");
                Console.WriteLine(" [5] SAIR");
            }
    }
}

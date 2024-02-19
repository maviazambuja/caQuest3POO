using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace caQuest3POO
{
    internal class Emprestimo
    {
        //atributos
        string nome_emprestimo;
        string carro_emprestado;
        int preco_diario;
        int qnt_dias;
        int preco_final;

        //metodos
        public Emprestimo()
        {
            nome_emprestimo = string.Empty;
            carro_emprestado = string.Empty;
            preco_diario = 0;
            qnt_dias = 0;
            preco_final = 0;    


        }
        public Emprestimo(string _nome_emprestimo, string _carro_emprestado, int _preco_diario, int _qnt_dias, int _preco_final)
        {
            nome_emprestimo = _nome_emprestimo;
            carro_emprestado = _carro_emprestado;
            preco_diario = _preco_diario;
            qnt_dias = _qnt_dias;
            preco_final = _preco_final;
        }

        public void ControleEmprestimo(Emprestimo e)
        {
            listaemprestimo[cont_emprestimo] = e;
            cont_emprestimo++;

        }



        //getters e setters
        public string Nome_emprestimo { get => nome_emprestimo; set => nome_emprestimo = value; }
        public string Carro_emprestado { get => carro_emprestado; set => carro_emprestado = value; }
        public int Preco_diario { get => preco_diario; set => preco_diario = value; }
        public int Qnt_dias { get => qnt_dias; set => qnt_dias = value; }
        public int Preco_final { get => preco_final; set => preco_final = value; }
    }
}

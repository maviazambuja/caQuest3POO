using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuest3POO
{
    internal class Locadora
    {
        //controle dos emprestimos
        string categoria;
        string marca;
        string modelo;
        int ano;

        public Locadora() 
        {
            categoria = string.Empty;
            marca = string.Empty;
            modelo = string.Empty;
            ano = 0;
       
        
        }
        public Locadora(string _categoria, string _marca, string _modelo, int _ano)
        {
            categoria = _categoria;
            marca = _marca;
            modelo =_modelo;
            ano = _ano;
        }

        public void AdicionaCarro(Cliente l) 
        {
            listacliente[cont_cliente] = l;
            cont_cliente++;
        
        }
        


        //getters e setters
        public string Categoria { get => categoria; set => categoria = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Ano { get => ano; set => ano = value; }
    }
}


//public void adicionaMateria(Materia m)
//{
//    lista_materias[cont_materia] = m;
//    cont_materia++;
//}

//public void ImprimeMaterias()
//{

//    for (int w = 0; w < cont_materia; w++)
//    {
//        Console.WriteLine("Materia " + (w + 1) + ": " + lista_materias[w].Nome);
//    }
//}
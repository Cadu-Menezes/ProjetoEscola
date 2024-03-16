using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Professor
    {

        public string Matricula { get; set; }

        public string Nome { get; set; }    


        public Professor(string matricula, string nome) { 

            Matricula =  matricula;
            Nome = nome;    

        }

        public override string ToString()
        {
            return "Professor " + Nome + " Cadastrado com sucesso";
        }

    }
}

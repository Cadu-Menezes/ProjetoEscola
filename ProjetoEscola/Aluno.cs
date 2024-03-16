using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Aluno
    {

        public string Matricula { get; set; }
        public string Nome { get; set; }


        public Aluno(string matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;

        }


        public override string ToString()
        {
            return "O aluno " + Nome + "foi cadastrado com sucesso!";
        }


    }
  
}

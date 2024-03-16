using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Disciplina
    {

        public int Codigo {  get; set; }    

        public string Nome { get; set; }
    
        public Disciplina(int codigo, string nome) {

            Codigo = codigo;
            Nome = nome;    

        }

        public override string ToString()
        {
            return "Disciplina " + Nome + " Cadastrada com sucesso!";
        }

    }

}

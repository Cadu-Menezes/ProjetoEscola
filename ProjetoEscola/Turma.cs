using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Turma
    {
        public int Codigo {  get; set; }

        public string Nome { get; set; }

        public Professor  professor { get; set; }

        public Disciplina disciplina { get; set; }

        public List<Aluno> alunos { get; set; }

        public Turma(int codigo, string nome, Professor professores, Disciplina disciplinas)
        {
            Codigo = codigo;
            Nome = nome;
            professor = professores;
            disciplina = disciplinas;
            alunos = new List<Aluno>();
        }


        public override string ToString()
        {
            string alunosStr = "";
            foreach (var aluno in alunos)
            {
                alunosStr += "\n  - " + aluno.Nome;
            }
            return "Codigo da Turma: "+Codigo +     "//"     +     " Nome: " + Nome + " //" +         " Professor: " +  professor.Nome + "  //" +  " Disciplina: " + disciplina.Nome + " //" + " Alunos: " + alunosStr;
        }


        public void addAlunos(Turma turma, List<Aluno> alunos)
        {

             foreach (var aluno in alunos)
             {
                 turma.alunos.Add(aluno);
             }
            
             Console.WriteLine(turma.ToString());
        }

        public Boolean abrirTurma(Turma turma) {
            
            int numAlunos = turma.alunos.Count;
            if (numAlunos >= 1 && numAlunos <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void abrirPauta(Turma turma)
        {

            string alunosStr = "";
            foreach (var aluno in turma.alunos)
            {
                alunosStr += "\n  - " + aluno.Nome;
            }

            Console.WriteLine("PAUTA DA TURMA ----- Codigo da Turma: " + turma.Codigo + "//" + " Professor: " + turma.professor.Nome + "  //" + " Disciplina: " + turma.disciplina.Nome + " //" + " Alunos: " + alunosStr);
        }

    }
}

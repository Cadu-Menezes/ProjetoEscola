using System.Security.Cryptography.X509Certificates;

namespace ProjetoEscola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            List<Aluno> alunos = new List<Aluno>();

            Professor professor = new Professor("111", "Rodrigo");
            Console.WriteLine(professor);

            Disciplina disciplina = new Disciplina(1, "Matematica");
            Console.WriteLine(disciplina);


            cadastrarAlunos(alunos);

            Turma turma = new Turma(1, "Turma A", professor, disciplina);
            Console.WriteLine(turma);

            turma.addAlunos(turma, alunos);
            turma.abrirPauta(turma);
            var abrirturma = turma.abrirTurma(turma);
            
            if (abrirturma == true)
            {
                Console.WriteLine("Turma Aberta com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possivel abrir a turma!");
            }

        }

         public static void cadastrarAlunos(List<Aluno> alunos)
         {
            alunos.Add(new Aluno("111", "Cadu"));
            alunos.Add(new Aluno("222", "Yasmim"));
            alunos.Add(new Aluno("333", "Maria Clara"));
            alunos.Add(new Aluno("333", "Fernanda"));
            alunos.Add(new Aluno("333", "Olivia"));

        }





    }
}

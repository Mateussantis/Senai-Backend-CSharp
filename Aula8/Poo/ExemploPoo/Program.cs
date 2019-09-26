using System;
using ExemploPoo.Models;
namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aluno1
                AlunoModel aluno = new AlunoModel();
                aluno.CadastrarAluno();
                aluno.ExibirAluno();    
            #endregion
            
            #region Aluno2
                AlunoModel aluno2 = new AlunoModel();
                aluno2.CadastrarAluno();
                aluno2.ExibirAluno();
            #endregion            
        }
    }
}

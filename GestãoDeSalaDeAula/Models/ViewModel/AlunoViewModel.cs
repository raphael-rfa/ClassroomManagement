namespace GestãoDeSalaDeAula.Models.ViewModel
{
    public class AlunoViewModel
    {
        public Alunos? aluno { get; set; }
        public Provas? provas { get; set; }

        public static implicit operator AlunoViewModel?(Alunos? v)
        {
            AlunoViewModel aluno;        
            aluno = new AlunoViewModel { aluno = v };
            return aluno;            
            throw new NotImplementedException();
        }
    }
}

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

        public static implicit operator AlunoViewModel?(Provas? p)
        {
            Alunos alunos = new Alunos { Id = p!.Aluno!.Id, Name = p.Aluno.Name};
            AlunoViewModel prova;
            prova = new AlunoViewModel { provas = p, aluno = alunos};
            prova.provas.AlunosId = p.Aluno.Id;
            return prova;
            throw new NotImplementedException();
        }
    }
}

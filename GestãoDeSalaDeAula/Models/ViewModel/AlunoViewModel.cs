namespace ClassroomManagement.Models.ViewModel
{
    public class AlunoViewModel
    {
        public Student? aluno { get; set; }
        public Exam? provas { get; set; }

        public static implicit operator AlunoViewModel?(Student? v)
        {
            AlunoViewModel aluno;        
            aluno = new AlunoViewModel { aluno = v };
            return aluno;            
            throw new NotImplementedException();
        }

        public static implicit operator AlunoViewModel?(Exam? p)
        {
            Student alunos = new Student { Id = p!.Student!.Id, Name = p.Student.Name};
            AlunoViewModel prova;
            prova = new AlunoViewModel { provas = p, aluno = alunos};
            prova.provas.StudentId = p.Student.Id;
            return prova;
            throw new NotImplementedException();
        }
    }
}

namespace ClassroomManagement.Models.ViewModel
{
    public class ProfessorProvas
    {

        public Professor? Professores { get; set; }
        public Subject? Materias { get; set; }
        public Student? Alunos { get; set; }

        public static implicit operator ProfessorProvas?(Professor? v)
        {
            ProfessorProvas p = new ProfessorProvas() 
            {
                Professores = v, Materias = v!.ProfessorSubject.Subject
            };
            return p;
            throw new NotImplementedException();
        }
    }
}

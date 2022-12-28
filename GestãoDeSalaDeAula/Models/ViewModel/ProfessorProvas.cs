namespace GestãoDeSalaDeAula.Models.ViewModel
{
    public class ProfessorProvas
    {

        public Professores? Professores { get; set; }
        public Materias? Materias { get; set; }
        public Alunos? Alunos { get; set; }

        public static implicit operator ProfessorProvas?(Professores? v)
        {
            ProfessorProvas p = new ProfessorProvas() 
            {
                Professores = v, Materias = v!.ProfessorMateria.Materia
            };
            return p;
            throw new NotImplementedException();
        }
    }
}

namespace GestãoDeSalaDeAula.Models
{
    public class ProfessorMateria
    {
        public int ProfessoresId { get; set;}
        public int MateriasId { get; set; }
        public Professores? Professor { get; set; }
        public Materias? Materia { get; set; }
    }
}

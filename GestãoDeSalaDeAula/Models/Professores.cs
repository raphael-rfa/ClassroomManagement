namespace GestãoDeSalaDeAula.Models
{
    public class Professores
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Materias? Materias { get; set; }
        public ProfessorMateria? ProfessorMateria { get; set; }
    }
}

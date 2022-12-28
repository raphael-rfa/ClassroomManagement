namespace GestãoDeSalaDeAula.Models
{
    public class Professores
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Materias>? Materias { get; set; }
    }
}

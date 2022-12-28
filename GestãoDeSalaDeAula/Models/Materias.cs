using System.ComponentModel.DataAnnotations;

namespace GestãoDeSalaDeAula.Models
{
    public class Materias
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string? MateriasName { get; set; }

        public ICollection<ProfessorMateria>? ProfessorMateria { get; set; }
        public ICollection<Provas>? Provas { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GestãoDeSalaDeAula.Models
{
    public class Alunos
    {
        public int Id { get; set; }
        [Display(Name = "Nome completo")]
        public string? Name { get; set; }
        
        public ICollection<Provas>? Provas { get; set; }
    }
}

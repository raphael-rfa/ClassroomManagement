using System.ComponentModel.DataAnnotations;

namespace GestãoDeSalaDeAula.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        
        public ICollection<Provas>? Provas { get; set; }
    }
}

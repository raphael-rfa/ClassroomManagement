using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestãoDeSalaDeAula.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        [Display(Name = "Nota 1")]
        public double Nota1 { get; set; }
        [Display(Name = "Nota 2")]
        public double Nota2 { get; set; }
        [Display(Name = "Nota 3")]
        public double Nota3 { get; set; }
        [Display(Name = "Nota 4")]
        public double Nota4 { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Media
        {
            get { return (Nota1 + Nota2 + Nota3 + Nota4) / 4; }
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GestãoDeSalaDeAula.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Display(Name = "Nota 1")]
        [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas de 0 a 10 por favor !")]
        public double Nota1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Display(Name = "Nota 2")]
        [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas de 0 a 10 por favor !")]
        public double Nota2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Display(Name = "Nota 3")]
        [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas de 0 a 10 por favor !")]
        public double Nota3 { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Display(Name = "Nota 4")]
        [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas de 0 a 10 por favor !")]
        public double Nota4 { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Media
        {
            get { return (Nota1 + Nota2 + Nota3 + Nota4) / 4; }
        }
    }
}

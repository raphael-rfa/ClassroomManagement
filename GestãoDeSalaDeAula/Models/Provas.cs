using System.ComponentModel.DataAnnotations;

namespace GestãoDeSalaDeAula.Models
{
    public class Provas
    {
        public int ProvasId { get; set; }
        public int AlunosId { get; set;}
        public int MateriasId { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas são de 0 a 10 seu bruxo !")]
        public double Nota { get; set; }         
        public Alunos? Aluno { get; set; }
        public Materias? Materia { get; set; }
    }
}

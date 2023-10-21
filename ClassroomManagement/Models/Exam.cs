using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public int StudentId { get; set;}
        public int SubjectId { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas são de 0 a 10 seu bruxo !")]
        public double Score { get; set; }         
        public Student? Student { get; set; }
        public Subject? Subject { get; set; }
    }
}

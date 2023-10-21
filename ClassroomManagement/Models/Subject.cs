using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string? SubjectName { get; set; }

        public ICollection<ProfessorSubject>? ProfessorSubject { get; set; }
        public ICollection<Exam>? Exams { get; set; }
    }
}

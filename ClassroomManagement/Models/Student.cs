using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Nome completo")]
        public string? Name { get; set; }
        
        public ICollection<Exam>? Exams { get; set; }
    }
}

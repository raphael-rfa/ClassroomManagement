using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public sealed class Student : BaseEntiy
{
    [Display(Name = "Nome completo")]
    public string? Name { get; set; }
    
    public ICollection<Exam>? Exams { get; set; }
}

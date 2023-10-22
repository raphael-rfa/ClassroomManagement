using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public sealed class Subject : BaseEntiy
{
    [MaxLength(50)]
    public string? SubjectName { get; set; }

    public ICollection<ProfessorSubject>? ProfessorSubject { get; set; }
    public ICollection<Exam>? Exams { get; set; }
}

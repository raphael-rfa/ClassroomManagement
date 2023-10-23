using ClassroomManagement.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public sealed class Student : BaseEntiy
{
    private Student() { }
    public Student(Name name)
    {
        Name = name;
    }

    [Display(Name = "Nome completo")]
    public Name Name { get; private set; }
    
    public IReadOnlyCollection<Exam>? Exams { get; set; }
}

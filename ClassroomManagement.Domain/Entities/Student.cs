using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public sealed class Student : BaseEntiy
{
    public Student(string name)
    {
        Name = name;

        if (string.IsNullOrEmpty(Name))
            throw new ArgumentNullException(nameof(name));
    }

    [Display(Name = "Nome completo")]
    public string Name { get; private set; }
    
    public IReadOnlyCollection<Exam>? Exams { get; set; }
}

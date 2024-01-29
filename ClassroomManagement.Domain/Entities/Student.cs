using ClassroomManagement.Domain.ValueObjects;

namespace ClassroomManagement.Domain.Entities;

public sealed class Student : BaseEntiy
{
    private Student() { }
    public Student(Name name)
    {
        Name = name;
    }

    public Name Name { get; private set; }
    
    public IReadOnlyCollection<Exam>? Exams { get; set; }
}

using ClassroomManagement.Domain.ValueObjects;

namespace ClassroomManagement.Domain.Entities;

public class Professor : BaseEntiy
{
    private Professor() {}
    public Professor(Name name)
    {
        Name = name;
    }

    public Name Name { get; private set; }
    public Subject? Subject { get; private set; }
    public ProfessorSubject? ProfessorSubject { get; private set; }
}

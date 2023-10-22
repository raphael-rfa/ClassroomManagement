namespace ClassroomManagement.Domain.Entities;

public class Professor : BaseEntiy
{
    public Professor(string name)
    {
        Name = name;

        if (string.IsNullOrEmpty(Name))
            throw new ArgumentNullException(nameof(name));
    }

    public string Name { get; private set; }
    public Subject? Subject { get; private set; }
    public ProfessorSubject? ProfessorSubject { get; private set; }
}

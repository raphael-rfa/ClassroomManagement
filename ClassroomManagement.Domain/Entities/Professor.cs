namespace ClassroomManagement.Domain.Entities;

public class Professor : BaseEntiy
{
    public string? Name { get; set; }
    public Subject? Subject { get; set; }
    public ProfessorSubject? ProfessorSubject { get; set; }
}

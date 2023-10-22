namespace ClassroomManagement.Domain.Entities;

public sealed class ProfessorSubject
{
    public int ProfessorId { get; set;}
    public int SubjectId { get; set; }
    public Professor? Professor { get; set; }
    public Subject? Subject { get; set; }
}

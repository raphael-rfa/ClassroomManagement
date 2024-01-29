using ClassroomManagement.Domain.Tools;

namespace ClassroomManagement.Domain.Entities;

public sealed class ProfessorSubject
{
    public ProfessorSubject(int professorId, int subjectId)
    {
        ProfessorId = professorId.ThrowIfEqualZero("ProfessorId é 0");
        SubjectId = subjectId.ThrowIfEqualZero("SubjectId é 0");
    }

    public int ProfessorId { get; private set;}
    public int SubjectId { get; private set; }
    public Professor? Professor { get; set; }
    public Subject? Subject { get; set; }
}

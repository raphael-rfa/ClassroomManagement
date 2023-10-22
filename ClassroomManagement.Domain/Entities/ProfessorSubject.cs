namespace ClassroomManagement.Domain.Entities;

public sealed class ProfessorSubject
{
    public ProfessorSubject(int professorId, int subjectId)
    {
        ProfessorId = professorId;
        SubjectId = subjectId;

        if (professorId == 0 || subjectId == 0)
            throw new Exception("StudentId or SubjectId invalid.");
    }

    public int ProfessorId { get; private set;}
    public int SubjectId { get; private set; }
    public Professor? Professor { get; set; }
    public Subject? Subject { get; set; }
}

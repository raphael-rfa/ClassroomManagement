using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Web.ViewModels;

public class ProfessorExam
{

    public Professor? Professor { get; set; }
    public Subject? Subject { get; set; }
    public Student? Student { get; set; }

    public static implicit operator ProfessorExam?(ProfessorSubject v)
    {
        ProfessorExam p = new ()
        {
            Professor = v.Professor,
            Subject = v.Subject
        };
        return p;
    }
}

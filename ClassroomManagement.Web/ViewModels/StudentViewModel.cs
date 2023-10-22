using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Web.ViewModels;

public class StudentViewModel
{
    public Student? Student { get; set; }
    public Exam? Exam { get; set; }

    public static implicit operator StudentViewModel?(Student? v)
    {
        StudentViewModel student;
        student = new StudentViewModel { Student = v };
        return student;
        throw new NotImplementedException();
    }

    public static implicit operator StudentViewModel?(Exam p)
    {
        Student student = new Student(p.Student!.Name) { Id = p.Student!.Id};
        StudentViewModel exam;
        exam = new StudentViewModel { Exam = p, Student = student };
        return exam;
        throw new NotImplementedException();
    }
}

using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public class Exam : BaseEntiy
{
    public Exam(int studentId, int subjectId, double score)
    {
        StudentId = studentId;
        SubjectId = subjectId;
        Score = score;

        if (studentId == 0 || subjectId == 0)
            throw new Exception("StudentId or SubjectId invalid.");
    }

    public int StudentId { get; private set;}
    public int SubjectId { get; private set; }

    [DisplayFormat(DataFormatString = "{0:0.00}")]
    [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas são de 0 a 10 seu bruxo !")]
    public double Score { get; private set; }         
    public Student? Student { get; private set; }
    public Subject? Subject { get; private set; }
}

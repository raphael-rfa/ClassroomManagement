using ClassroomManagement.Domain.Tools;
using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public class Exam : BaseEntiy
{
    public Exam(int studentId, int subjectId, double score)
    {
        StudentId = studentId.ThrowIfEqualZero("StudentId é 0");
        SubjectId = subjectId.ThrowIfEqualZero("SubjectId é 0");
        Score = score;
    }

    public int StudentId { get; private set;}
    public int SubjectId { get; private set; }
    
    [DisplayFormat(DataFormatString = "{0:0.00}")]
    [Range(0.00, 10.00, ErrorMessage = "Tu é o mestre dos magos ? Notas são de 0 a 10 seu bruxo !")]
    public double Score { get; private set; }         
    public Student? Student { get; private set; }
    public Subject? Subject { get; private set; }
}

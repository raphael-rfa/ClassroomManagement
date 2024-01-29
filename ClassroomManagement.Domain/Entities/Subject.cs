using ClassroomManagement.Domain.Tools;
using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public sealed class Subject : BaseEntiy
{
    public Subject(string subjectName)
    {
        SubjectName = subjectName.ThrowIfNullOrEmpty(nameof(subjectName));
    }

    [MaxLength(50)]
    public string SubjectName { get; private set; }
    public IReadOnlyCollection<Exam>? Exams { get; set; }
}

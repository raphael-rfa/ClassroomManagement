using System.ComponentModel.DataAnnotations;

namespace ClassroomManagement.Domain.Entities;

public sealed class Subject : BaseEntiy
{
    public Subject(string subjectName)
    {
        SubjectName = subjectName;

        if (string.IsNullOrEmpty(subjectName))
            throw new ArgumentNullException(nameof(subjectName));
    }

    [MaxLength(50)]
    public string SubjectName { get; private set; }
    public IReadOnlyCollection<Exam>? Exams { get; set; }
}

using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Domain.Interfaces;

public interface IExamRepository : IBaseRepository<Exam>
{
    Task<bool> Any(int id);
    Task<Exam> GetWithStudentAndSubject(int id);
}

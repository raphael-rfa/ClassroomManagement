using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Domain.Interfaces.Repositories;

public interface IExamRepository : IBaseRepository<Exam>
{
    Task<bool> Any(int id);
    Task<Exam> GetWithStudentAndSubject(int id);
}

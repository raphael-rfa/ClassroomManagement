using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Domain.Interfaces.Repositories;

public interface IStudentRepository : IBaseRepository<Student>
{
    Task<List<Student>> GetAllWithExams();
    Task<Student?> GetWithExams(int id);
    Task<bool> Any(int id);
}

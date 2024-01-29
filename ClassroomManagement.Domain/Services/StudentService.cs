using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Infrastructure.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class StudentService : BaseService<Student>, IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository) : base(studentRepository)
    {
        this._studentRepository = studentRepository;
    }

    public Task<bool> Any(int id)
    {
        return _studentRepository.Any(id);
    }

    public async Task<List<AverageScoreGroup>> GetStudentsWithAverageScores()
    {
        List<Student> students = await _studentRepository.GetAllWithExams();

        return students
            .Select(x => new AverageScoreGroup
            {
                Id = x.Id,
                Name = x.Name,
                Average = x.Exams?.Average(a => a.Score) ?? 0
            })
            .OrderByDescending(a => a.Average)
            .ToList();
    }

    public async Task<Student> GetWithExams(int id)
    {
        return await _studentRepository.GetWithExams(id);
    }
}

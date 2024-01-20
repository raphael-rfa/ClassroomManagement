using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        this._studentRepository = studentRepository;
    }

    public Task<bool> Any(int id)
    {
        return _studentRepository.Any(id);
    }

    public Task Create(Student entity)
    {
        return _studentRepository.Create(entity);
    }

    public void Delete(Student entity)
    {
        _studentRepository.Delete(entity);
    }

    public Task<Student> Get(int id, CancellationToken cancellationToken = default)
    {
        return _studentRepository.Get(id, cancellationToken);
    }

    public Task<List<Student>> GetAll(CancellationToken cancellationToken = default)
    {
        return _studentRepository.GetAll(cancellationToken);
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

    public void Update(Student entity)
    {
        _studentRepository.Update(entity);
    }
}

using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class ExamService : IExamService
{
    private readonly IExamRepository _ExamRepository;

    public ExamService(IExamRepository ExamRepository)
    {
        this._ExamRepository = ExamRepository;
    }

    public async Task<bool> Any(int id)
    {
        return await _ExamRepository.Any(id);
    }

    public Task Create(Exam entity)
    {
        return _ExamRepository.Create(entity);
    }

    public void Delete(Exam entity)
    {
        _ExamRepository.Delete(entity);
    }

    public Task<Exam> Get(int id, CancellationToken cancellationToken = default)
    {
        return _ExamRepository.Get(id, cancellationToken);
    }

    public Task<List<Exam>> GetAll(CancellationToken cancellationToken = default)
    {
        return _ExamRepository.GetAll(cancellationToken);
    }

    public async Task<StudentViewModel> GetWithStudentAndSubject(int id)
    {
        return await _ExamRepository.GetWithStudentAndSubject(id);
    }

    public void Update(Exam entity)
    {
        _ExamRepository.Update(entity);
    }
}

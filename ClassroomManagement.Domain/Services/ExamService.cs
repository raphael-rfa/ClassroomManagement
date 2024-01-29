using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Infrastructure.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class ExamService : BaseService<Exam>, IExamService
{
    private readonly IExamRepository _ExamRepository;

    public ExamService(IExamRepository ExamRepository) : base(ExamRepository)
    {
        this._ExamRepository = ExamRepository;
    }

    public async Task<bool> Any(int id)
    {
        return await _ExamRepository.Any(id);
    }

    public async Task<StudentViewModel> GetWithStudentAndSubject(int id)
    {
        return await _ExamRepository.GetWithStudentAndSubject(id);
    }
}

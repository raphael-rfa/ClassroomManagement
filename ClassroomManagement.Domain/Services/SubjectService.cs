using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Infrastructure.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class SubjectService : BaseService<Subject>, ISubjectService
{
    private readonly ISubjectRepository _SubjectRepository;

    public SubjectService(ISubjectRepository SubjectRepository) : base(SubjectRepository)
    {
        this._SubjectRepository = SubjectRepository;
    }
}

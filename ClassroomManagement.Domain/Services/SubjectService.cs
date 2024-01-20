using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class SubjectService : ISubjectService
{
    private readonly ISubjectRepository _SubjectRepository;

    public SubjectService(ISubjectRepository SubjectRepository)
    {
        this._SubjectRepository = SubjectRepository;
    }

    public Task Create(Subject entity)
    {
        return _SubjectRepository.Create(entity);
    }

    public void Delete(Subject entity)
    {
        _SubjectRepository.Delete(entity);
    }

    public Task<Subject> Get(int id, CancellationToken cancellationToken = default)
    {
        return _SubjectRepository.Get(id, cancellationToken);
    }

    public Task<List<Subject>> GetAll(CancellationToken cancellationToken = default)
    {
        return _SubjectRepository.GetAll(cancellationToken);
    }

    public void Update(Subject entity)
    {
        _SubjectRepository.Update(entity);
    }
}

using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class ProfessorService : IProfessorService
{
    private readonly IProfessorRepository _ProfessorRepository;

    public ProfessorService(IProfessorRepository ProfessorRepository)
    {
        this._ProfessorRepository = ProfessorRepository;
    }

    public Task Create(Professor entity)
    {
        return _ProfessorRepository.Create(entity);
    }

    public void Delete(Professor entity)
    {
        _ProfessorRepository.Delete(entity);
    }

    public Task<Professor> Get(int id, CancellationToken cancellationToken = default)
    {
        return _ProfessorRepository.Get(id, cancellationToken);
    }

    public Task<List<Professor>> GetAll(CancellationToken cancellationToken = default)
    {
        return _ProfessorRepository.GetAll(cancellationToken);
    }

    public void Update(Professor entity)
    {
        _ProfessorRepository.Update(entity);
    }
}

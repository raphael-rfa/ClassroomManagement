using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class ProfessorSubjectService : IProfessorSubjectService
{
    private readonly IProfessorSubjectRepository _ProfessorSubjectRepository;

    public ProfessorSubjectService(IProfessorSubjectRepository ProfessorSubjectRepository)
    {
        this._ProfessorSubjectRepository = ProfessorSubjectRepository;
    }

    public Task Create(ProfessorSubject entity)
    {
        return _ProfessorSubjectRepository.Create(entity);
    }

    public void Delete(ProfessorSubject entity)
    {
        _ProfessorSubjectRepository.Delete(entity);
    }

    public Task<ProfessorSubject> Get(int professorId, int subjectId, CancellationToken cancellationToken = default)
    {
        return _ProfessorSubjectRepository.Get(professorId, subjectId, cancellationToken);
    }

    public Task<List<ProfessorSubject>> GetAll(CancellationToken cancellationToken = default)
    {
        return _ProfessorSubjectRepository.GetAll(cancellationToken);
    }

    public async Task<List<ProfessoresViewModel>> GetProfessorsAndSubjectsAsync()
    {
        var professorsSubject = await _ProfessorSubjectRepository.GetProfessorsAndSubjectsAsync();

        List<ProfessoresViewModel> professoresViewModel = professorsSubject
            .Select(x => new ProfessoresViewModel
            {
                ProfessorId = x.Professor!.Id,
                ProfessorName = x.Professor!.Name,
                SubjectName = x.Subject!.SubjectName,
                SubjectId = x.Subject!.Id,
            }).ToList();

        return professoresViewModel;
    }

    public void Update(ProfessorSubject entity)
    {
        _ProfessorSubjectRepository.Update(entity);
    }
}

using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Domain.Interfaces;

public interface IProfessorSubjectRepository
{
    Task Create(ProfessorSubject entity);
    void Update(ProfessorSubject entity);
    void Delete(ProfessorSubject entity);
    Task<ProfessorSubject> Get(int professorId, int subjectId, CancellationToken cancellationToken = default);
    Task<List<ProfessorSubject>> GetAll(CancellationToken cancellationToken);
    Task<List<ProfessorSubject>> GetProfessorsAndSubjectsAsync();
}

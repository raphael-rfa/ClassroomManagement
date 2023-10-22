using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Infrastructure.Repositories;

public class ProfessorSubjectRepository : IProfessorSubjectRepository
{
    private readonly ClassroomManagementContext _context; 
    public ProfessorSubjectRepository(ClassroomManagementContext context)
    {
        _context = context;
    }
    public async Task Create(ProfessorSubject entity)
    {
        await _context.AddAsync(entity);
    }

    public void Update(ProfessorSubject entity)
    {
        _context.Update(entity);
    }

    public void Delete(ProfessorSubject entity)
    {
        _context.Remove(entity);
    }

    public async Task<ProfessorSubject> Get(int professorId, int subjectId, CancellationToken cancellationToken = default)
    {
        return await _context.Set<ProfessorSubject>()
            .AsNoTracking()
            .Include(x => x.Professor)
            .Include(x => x.Subject)
                .ThenInclude(x => x.Exams)
                    .ThenInclude(x => x.Student)
            .FirstOrDefaultAsync(x => x.ProfessorId == professorId && x.SubjectId == subjectId, cancellationToken);
    }

    public async Task<List<ProfessorSubject>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.Set<ProfessorSubject>().ToListAsync(cancellationToken);
    }

    public async Task<List<ProfessorSubject>> GetProfessorsAndSubjectsAsync()
    {
        return await _context.Set<ProfessorSubject>()
            .AsNoTracking()
            .Include(x => x.Professor)
            .Include(x => x.Subject)
            .ToListAsync();
    }
}

using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Infrastructure.Repositories;

public class ExamRepository : BaseRepository<Exam>, IExamRepository
{
    public ExamRepository(ClassroomManagementContext context) : base(context)
    {
    }

    public async Task<bool> Any(int id)
    {
        return await Context.Set<Exam>()
            .AsNoTracking()
            .AnyAsync(s => s.Id == id);
    }

    public async Task<Exam> GetWithStudentAndSubject(int id)
    {
        return await Context.Set<Exam>()
            .Where(s => s.Id == id)
            .Include(s => s.Student)
            .Include(s => s.Subject)
            .FirstOrDefaultAsync();
    }
}

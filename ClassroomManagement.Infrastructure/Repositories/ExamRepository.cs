using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Queries;
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
            .Where(BaseQueries.Get<Exam>(id))
            .Include(s => s.Student)
            .Include(s => s.Subject)
            .FirstOrDefaultAsync();
    }
}

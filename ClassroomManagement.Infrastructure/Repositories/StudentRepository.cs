﻿using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Queries;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Infrastructure.Repositories;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(ClassroomManagementContext context) : base(context)
	{
    }

    public async Task<bool> Any(int id)
    {
        return await Context.Set<Student>()
            .AsNoTracking()
            .AnyAsync(BaseQueries.Get<Student>(id));
    }

    public async Task<List<Student>> GetAllWithExams()
    {
        return await Context.Set<Student>()
            .AsNoTracking()
            .Include(x => x.Exams)
            .ToListAsync();
    }

    public async Task<Student?> GetWithExams(int id)
    {
        return await Context.Set<Student>()
            .AsNoTracking()
            .Where(BaseQueries.Get<Student>(id))
            .Include(e => e.Exams)
                .ThenInclude(s => s.Subject)
            .FirstOrDefaultAsync();
    }
}

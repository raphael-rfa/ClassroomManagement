using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntiy
{
    protected readonly ClassroomManagementContext Context;
    public BaseRepository(ClassroomManagementContext context) 
    {
        Context = context;            
    }
    public async Task Create(T entity)
    {
        await Context.AddAsync(entity);
    }

    public void Update(T entity)
    {
        Context.Update(entity);
    }

    public void Delete(T entity)
    {
        Context.Remove(entity);
    }

    public async Task<T> Get(int id, CancellationToken cancellationToken)
    {
        return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return await Context.Set<T>().ToListAsync(cancellationToken);
    }
}

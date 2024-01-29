using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;

namespace ClassroomManagement.Infrastructure.Services;

public class BaseService<T> : IBaseService<T> where T : BaseEntiy
{
    protected readonly IBaseRepository<T> baseRepository;
    public BaseService(IBaseRepository<T> repository) 
    {
        baseRepository = repository;            
    }
    public async Task Create(T entity)
    {
        await baseRepository.Create(entity);
    }

    public void Update(T entity)
    {
        baseRepository.Update(entity);
    }

    public void Delete(T entity)
    {
        baseRepository.Delete(entity);
    }

    public async Task<T> Get(int id, CancellationToken cancellationToken)
    {
        return await baseRepository.Get(id, cancellationToken);
    }

    public async Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return await baseRepository.GetAll(cancellationToken);
    }
}

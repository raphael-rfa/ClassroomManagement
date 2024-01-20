using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Domain.Interfaces.Services;

public interface IBaseService<T> where T : BaseEntiy
{
    Task Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> Get(int id, CancellationToken cancellationToken = default);
    Task<List<T>> GetAll(CancellationToken cancellationToken = default);
}

namespace ClassroomManagement.Domain.Interfaces.Repositories;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken = default);
}

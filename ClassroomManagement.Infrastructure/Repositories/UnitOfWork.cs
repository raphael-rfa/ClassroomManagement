using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Infrastucture.Context;

namespace ClassroomManagement.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ClassroomManagementContext _context;
    public UnitOfWork(ClassroomManagementContext context) 
    {
        _context = context;
    }
    public async Task Commit(CancellationToken cancellationToken = default)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}

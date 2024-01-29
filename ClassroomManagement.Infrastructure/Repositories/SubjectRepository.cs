using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Infrastucture.Context;

namespace ClassroomManagement.Infrastructure.Repositories;

public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
{
    public SubjectRepository(ClassroomManagementContext context) : base(context)
	{
    }
}

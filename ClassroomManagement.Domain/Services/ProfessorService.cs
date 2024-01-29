using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Infrastructure.Services;
using ClassroomManagement.Web.ViewModels;

namespace ClassroomManagement.Domain.Services;

public class ProfessorService : BaseService<Professor>, IProfessorService
{
    private readonly IProfessorRepository _ProfessorRepository;

    public ProfessorService(IProfessorRepository ProfessorRepository) : base(ProfessorRepository)
    {
        this._ProfessorRepository = ProfessorRepository;
    }
}

using ClassroomManagement.Domain.Interfaces;
using ClassroomManagement.Infrastructure.Repositories;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClassroomManagement.Infrastructure;

public static class ServiceExtension
{
    public static void ConfigurePersistenceApp(this IServiceCollection services,                IConfiguration configuration)
    {
        services.AddDbContext<ClassroomManagementContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'GestãoDeSalaDeAulaContext' not found.")));

        services.AddScoped<IUnitOfWork, UnitOfWork>(); 
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ISubjectRepository, SubjectRepository>();
        services.AddScoped<IProfessorRepository, ProfessorRepository>();
        services.AddScoped<IProfessorSubjectRepository, ProfessorSubjectRepository>();
        services.AddScoped<IExamRepository, ExamRepository>();
    }
}

using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Domain.Services;
using ClassroomManagement.Infrastructure.Repositories;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClassroomManagement.Infrastructure;

public static class ServiceExtension
{
    public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ClassroomManagementContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'GestãoDeSalaDeAulaContext' not found.")));

        services.AddScoped<IUnitOfWork, UnitOfWork>(); 
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ISubjectRepository, SubjectRepository>();
        services.AddScoped<IProfessorRepository, ProfessorRepository>();
        services.AddScoped<IProfessorSubjectRepository, ProfessorSubjectRepository>();
        services.AddScoped<IExamRepository, ExamRepository>();
        services.AddScoped<IProfessorSubjectService, ProfessorSubjectService>();
        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<IExamService, ExamService>();
    }
}

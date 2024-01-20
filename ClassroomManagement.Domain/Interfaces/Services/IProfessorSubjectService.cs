using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement.Domain.Interfaces.Services
{
    public interface IProfessorSubjectService
    {
        Task Create(ProfessorSubject entity);
        void Update(ProfessorSubject entity);
        void Delete(ProfessorSubject entity);
        Task<ProfessorSubject> Get(int professorId, int subjectId, CancellationToken cancellationToken = default);
        Task<List<ProfessorSubject>> GetAll(CancellationToken cancellationToken);
        Task<List<ProfessoresViewModel>> GetProfessorsAndSubjectsAsync();
    }
}

using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement.Domain.Interfaces.Services
{
    public interface IExamService : IBaseService<Exam>
    {
        Task<bool> Any(int id);
        Task<StudentViewModel> GetWithStudentAndSubject(int id);
    }
}

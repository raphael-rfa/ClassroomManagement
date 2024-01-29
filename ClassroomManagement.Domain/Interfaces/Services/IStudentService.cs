using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement.Domain.Interfaces.Services
{
    public interface IStudentService : IBaseService<Student>
    {
        Task<List<AverageScoreGroup>> GetStudentsWithAverageScores();
        Task<Student> GetWithExams(int id);
        Task<bool> Any(int id);
    }
}

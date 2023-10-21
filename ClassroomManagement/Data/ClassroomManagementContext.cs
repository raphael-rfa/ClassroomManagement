using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassroomManagement.Models;

namespace ClassroomManagement.Data
{
    public class ClassroomManagementContext : DbContext
    {
        public ClassroomManagementContext (DbContextOptions<ClassroomManagementContext> options)
            : base(options)
        {
        }

        public DbSet<ClassroomManagement.Models.Student> Students { get; set; }
        public DbSet<ClassroomManagement.Models.Subject> Subjects { get; set; }
        public DbSet<ClassroomManagement.Models.Exam> Exams { get; set; }
        public DbSet<ClassroomManagement.Models.Professor> Professors { get; set; }
        public DbSet<ClassroomManagement.Models.ProfessorSubject> ProfessorsSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Exam>().ToTable("Exam");
            modelBuilder.Entity<Professor>().ToTable("Professor");
            modelBuilder.Entity<ProfessorSubject>().ToTable("ProfessoSubject");

            modelBuilder.Entity<ProfessorSubject>()
                .HasKey(p => new { p.SubjectId, p.ProfessorId });
        }

    }
}

using ClassroomManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Infrastucture.Context;

public class ClassroomManagementContext : DbContext
{
    public ClassroomManagementContext (DbContextOptions<ClassroomManagementContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<ProfessorSubject> ProfessorsSubjects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("Student");
        modelBuilder.Entity<Subject>().ToTable("Subject");
        modelBuilder.Entity<Exam>().ToTable("Exam");
        modelBuilder.Entity<Professor>().ToTable("Professor");
        modelBuilder.Entity<ProfessorSubject>().ToTable("ProfessorSubject");

        modelBuilder.Entity<ProfessorSubject>()
            .HasKey(p => new { p.SubjectId, p.ProfessorId });
    }

}

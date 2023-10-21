using ClassroomManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Data
{
    public static class SeedData
    {
        public static void Initialize(ClassroomManagementContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;//Banco de dados já foi semeado
            }           

            var alunos = new Student[]
            {
                new Student { Name = "Hermione Granger"},
                new Student { Name = "Harry Potter"},
                new Student { Name = "Ronald Weasley"},
                new Student { Name = "Dino Thomas"},
                new Student { Name = "Neville Longbottom"},
                new Student { Name = "Simas Finnigan"},
                new Student { Name = "Lilá Brown"},
                new Student { Name = "Parvati Patil"},
                new Student { Name = "Fay Dunbar"},
                new Student { Name = "Kellah"}
            };

            foreach (Student aluno in alunos)
            {
                context.Students.Add(aluno);
            }
            context.SaveChanges();
            
            var professores = new Professor[]
            {
                new Professor { Name = "Minerva McGonagall"},
                new Professor { Name = "Filius Flitwick"},
                new Professor { Name = "Severo Snape"},
                new Professor { Name = "Cuthbert Binns"},
                new Professor { Name = "Quirino Quirrell"},
                new Professor { Name = "Aurora Sinistra"},
                new Professor { Name = "Pomona Sprout"}
            };

            foreach (Professor professor in professores)
            {
                context.Professors.Add(professor);
            }
            context.SaveChanges();

            var materias = new Subject[]
            {
                new Subject { SubjectName = "Transfiguração"},
                new Subject { SubjectName = "Feitiços"},
                new Subject { SubjectName = "Poções"},
                new Subject { SubjectName = "Historia da Magia"},
                new Subject { SubjectName = "Defesa Contra as Artes das Trevas"},
                new Subject { SubjectName = "Astronomia"},
                new Subject { SubjectName = "Herbologia"}
            };

            foreach (Subject m in materias)
            {
                context.Subjects.Add(m);
            }
            context.SaveChanges();


            var professomateria = new ProfessorSubject[]
            {
                new ProfessorSubject { SubjectId = 
                    materias.Single(m => m.SubjectName == "Transfiguração").Id,
                    ProfessorId = professores.Single(p => p.Name == "Minerva McGonagall").Id
                },
                new ProfessorSubject { SubjectId = 
                    materias.Single(m => m.SubjectName == "Feitiços").Id,
                    ProfessorId = professores.Single(p => p.Name == "Filius Flitwick").Id
                },
                new ProfessorSubject { SubjectId = 
                    materias.Single(m => m.SubjectName == "Poções").Id,
                    ProfessorId = professores.Single(p => p.Name == "Severo Snape").Id
                },
                new ProfessorSubject { SubjectId = 
                    materias.Single(m => m.SubjectName == "Historia da Magia").Id,
                    ProfessorId = professores.Single(p => p.Name == "Cuthbert Binns").Id
                },
                new ProfessorSubject { SubjectId = 
                    materias.Single(m => m.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    ProfessorId = professores.Single(p => p.Name == "Quirino Quirrell").Id
                },
                new ProfessorSubject { SubjectId = 
                    materias.Single(m => m.SubjectName == "Astronomia").Id,
                    ProfessorId = professores.Single(p => p.Name == "Aurora Sinistra").Id
                },
                new ProfessorSubject { SubjectId = 
                    materias.Single(m => m.SubjectName == "Herbologia").Id,
                    ProfessorId = professores.Single(p => p.Name == "Pomona Sprout").Id
                }
                
            };

            foreach (ProfessorSubject pm in professomateria)
            {
                context.ProfessorsSubjects.Add(pm);
            }

            context.SaveChanges();
            
            var provas = new Exam[]
            {
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 9.1
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 9.8
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 4.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 6.3
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 8.7
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 8.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 8.9 
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 7.8
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 5.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 6.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 7.5
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 6.8
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 7.1
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 7
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 6.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 8
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 8.3
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 7.6
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 7
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 6.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 7.3
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 0
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 8.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 7.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 6.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 10
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 7.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 4.5
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 3.2
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 8.7
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 8.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 7.8
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 5.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 8.5
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 8.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 9.6
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 8
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 7.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 6.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 9.5
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 9.1
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 8.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 8.5
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 6.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 7.9
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 5.5
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 3.4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 2
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 7
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 5.6
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 4.7
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 7.8
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 8.1
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Kellah").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Transfiguração").Id,
                    Score = 5.3
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Kellah").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Feitiços").Id,
                    Score = 7.6
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Kellah").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Poções").Id,
                    Score = 8.3
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Kellah").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Historia da Magia").Id,
                    Score = 3
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Kellah").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,
                    Score = 4
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Kellah").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Astronomia").Id,
                    Score = 9.3
                },
                new Exam {
                    StudentId = alunos.Single(a => a.Name == "Kellah").Id,
                    SubjectId = materias.Single(a => a.SubjectName == "Herbologia").Id,
                    Score = 8
                }
            };

            foreach (Exam p in provas)
            {
                var ProvasNoBanco = context.Exams.Where(
                    s =>
                            s.Student.Id == p.StudentId &&
                            s.Subject.Id == p.SubjectId).SingleOrDefault();
                if (ProvasNoBanco == null)
                {
                    context.Exams.Add(p);
                }
            }
            context.SaveChanges();
        }
    }
}
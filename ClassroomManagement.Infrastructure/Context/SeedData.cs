using ClassroomManagement.Domain.Entities;

namespace ClassroomManagement.Infrastucture.Context;

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
            new Student("Hermione Granger"),
            new Student("Harry Potter"),
            new Student("Ronald Weasley"),
            new Student("Dino Thomas"),
            new Student("Neville Longbottom"),
            new Student("Simas Finnigan"),
            new Student("Lilá Brown"),
            new Student("Parvati Patil"),
            new Student("Fay Dunbar"),
            new Student("Kellah")
        };

        foreach (Student aluno in alunos)
        {
            context.Students.Add(aluno);
        }
        context.SaveChanges();
        
        var professores = new Professor[]
        {
            new Professor ("Minerva McGonagall"),
            new Professor ("Filius Flitwick"),
            new Professor ("Severo Snape"),
            new Professor ("Cuthbert Binns"),
            new Professor ("Quirino Quirrell"),
            new Professor ("Aurora Sinistra"),
            new Professor ("Pomona Sprout")
        };

        foreach (Professor professor in professores)
        {
            context.Professors.Add(professor);
        }
        context.SaveChanges();

        var materias = new Subject[]
        {
            new Subject ("Transfiguração"),
            new Subject ("Feitiços"),
            new Subject ("Poções"),
            new Subject ("Historia da Magia"),
            new Subject ("Defesa Contra as Artes das Trevas"),
            new Subject ("Astronomia"),
            new Subject ("Herbologia")
        };

        foreach (Subject m in materias)
        {
            context.Subjects.Add(m);
        }
        context.SaveChanges();


        var professomateria = new ProfessorSubject[]
        {
            new ProfessorSubject (materias.Single(m => m.SubjectName == "Transfiguração").Id,professores.Single(p => p.Name == "Minerva McGonagall").Id),
            new ProfessorSubject (materias.Single(m => m.SubjectName == "Feitiços").Id,professores.Single(p => p.Name == "Filius Flitwick").Id),
            new ProfessorSubject (materias.Single(m => m.SubjectName == "Poções").Id,professores.Single(p => p.Name == "Severo Snape").Id),
            new ProfessorSubject (materias.Single(m => m.SubjectName == "Historia da Magia").Id,professores.Single(p => p.Name == "Cuthbert Binns").Id),
            new ProfessorSubject (materias.Single(m => m.SubjectName == "Defesa Contra as Artes das Trevas").Id,professores.Single(p => p.Name == "Quirino Quirrell").Id),
            new ProfessorSubject (materias.Single(m => m.SubjectName == "Astronomia").Id,professores.Single(p => p.Name == "Aurora Sinistra").Id),
            new ProfessorSubject (materias.Single(m => m.SubjectName == "Herbologia").Id,professores.Single(p => p.Name == "Pomona Sprout").Id)
            
        };

        foreach (ProfessorSubject pm in professomateria)
        {
            context.ProfessorsSubjects.Add(pm);
        }

        context.SaveChanges();
        
        var provas = new Exam[]
        {
            new Exam(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,10),
            new Exam(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,10),
            new Exam(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Poções").Id,10),
            new Exam(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,10),
            new Exam(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes daTrevas").Id,10),
            new Exam(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,10),
            new Exam(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,10),
            new Exam(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,9.1),
            new Exam(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,9.8),
            new Exam(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Poções").Id,4.9),
            new Exam(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,6.3),
            new Exam(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes daTrevas").Id,10),
            new Exam(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,8.7),
            new Exam(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,8.4),
            new Exam(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,8.9 ),
            new Exam(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,7.8),
            new Exam(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Poções").Id,5.9),
            new Exam(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,6.9),
            new Exam(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes daTrevas").Id,10),
            new Exam(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,7.5),
            new Exam(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,6.8),
            new Exam(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,7.1),
            new Exam(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,7),
            new Exam(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Poções").Id,6.4),
            new Exam(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,8),
            new Exam(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes daTrevas").Id,8.3),
            new Exam(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,7.6),
            new Exam(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,7),
            new Exam(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,6.9),
            new Exam(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,7.3),
            new Exam(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Poções").Id,0),
            new Exam(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,8.9),
            new Exam (alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,7.9),
            new Exam (alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,6.4),
            new Exam (alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,10),
            new Exam (alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,7.4),
            new Exam (alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,4.5),
            new Exam (alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Poções").Id,3.2),
            new Exam (alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,8.7),
            new Exam (alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,8.9),
            new Exam (alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,7.8),
            new Exam (alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,5.4),
            new Exam (alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,9),
            new Exam (alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,8.5),
            new Exam (alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Poções").Id,8.9),
            new Exam (alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,9.6),
            new Exam (alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,8),
            new Exam (alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,7.9),
            new Exam (alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,6.4),
            new Exam (alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,9.5),
            new Exam (alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,9.1),
            new Exam (alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Poções").Id,8.9),
            new Exam (alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,8.5),
            new Exam (alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,6.4),
            new Exam (alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,7.9),
            new Exam (alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,5.5),
            new Exam (alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id,3.4),
            new Exam (alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Feitiços").Id,2),
            new Exam (alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Poções").Id,7),
            new Exam (alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id,5.6),
            new Exam (alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,4.7),
            new Exam (alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Astronomia").Id,7.8),
            new Exam (alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Herbologia").Id,8.1),
            new Exam (alunos.Single(a => a.Name == "Kellah").Id,materias.Single(a => a.SubjectName == "Transfiguração").Id,5.3),
            new Exam (alunos.Single(a => a.Name == "Kellah").Id,materias.Single(a => a.SubjectName == "Feitiços").Id,7.6),
            new Exam (alunos.Single(a => a.Name == "Kellah").Id,materias.Single(a => a.SubjectName == "Poções").Id,8.3),
            new Exam (alunos.Single(a => a.Name == "Kellah").Id,materias.Single(a => a.SubjectName == "Historia da Magia").Id,3),
            new Exam (alunos.Single(a => a.Name == "Kellah").Id,materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id,4),
            new Exam (alunos.Single(a => a.Name == "Kellah").Id,materias.Single(a => a.SubjectName == "Astronomia").Id,9.3),
            new Exam (alunos.Single(a => a.Name == "Kellah").Id,materias.Single(a => a.SubjectName == "Herbologia").Id,8)
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
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
            new (new("Hermione","Granger")),
            new (new("Harry","Potter")),
            new (new("Ronald","Weasley")),
            new (new("Dino","Thomas")),
            new (new("Neville","Longbottom")),
            new (new("Simas","Finnigan")),
            new (new("Lilá","Brown")),
            new (new("Parvati","Patil")),
            new (new("Fay","Dunbar"))
        };

        context.Students.AddRange(alunos);

        context.SaveChanges();

        var professores = new Professor[]
        {
            new (new ("Minerva","McGonagall")),
            new (new ("Filius","Flitwick")),
            new (new ("Severo","Snape")),
            new (new ("Cuthbert","Binns")),
            new (new ("Quirino","Quirrell")),
            new (new ("Aurora","Sinistra")),
            new (new ("Pomona","Sprout"))
        };

        context.Professors.AddRange(professores);

        context.SaveChanges();

        var materias = new Subject[]
        {
            new ("Transfiguração"),
            new ("Feitiços"),
            new ("Poções"),
            new ("Historia da Magia"),
            new ("Defesa Contra as Artes das Trevas"),
            new ("Astronomia"),
            new ("Herbologia")
        };

        context.Subjects.AddRange(materias);

        context.SaveChanges();


        var professomateria = new ProfessorSubject[]
        {
            new(materias.Single(m => m.SubjectName == "Transfiguração").Id,professores.Single(p => p.Name == "Minerva McGonagall").Id),
            new(materias.Single(m => m.SubjectName == "Feitiços").Id,professores.Single(p => p.Name == "Filius Flitwick").Id),
            new(materias.Single(m => m.SubjectName == "Poções").Id,professores.Single(p => p.Name == "Severo Snape").Id),
            new(materias.Single(m => m.SubjectName == "Historia da Magia").Id,professores.Single(p => p.Name == "Cuthbert Binns").Id),
            new(materias.Single(m => m.SubjectName == "Defesa Contra as Artes das Trevas").Id,professores.Single(p => p.Name == "Quirino Quirrell").Id),
            new(materias.Single(m => m.SubjectName == "Astronomia").Id,professores.Single(p => p.Name == "Aurora Sinistra").Id),
            new(materias.Single(m => m.SubjectName == "Herbologia").Id,professores.Single(p => p.Name == "Pomona Sprout").Id)

        };

        context.ProfessorsSubjects.AddRange(professomateria);

        context.SaveChanges();

        var provas = new List<Exam>();

        provas.Add(new(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Poções").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Hermione Granger").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 9.1));
        provas.Add(new(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 9.8));
        provas.Add(new(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Poções").Id, 4.9));
        provas.Add(new(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 6.3));
        provas.Add(new(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 8.7));
        provas.Add(new(alunos.Single(a => a.Name == "Harry Potter").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 8.4));
        provas.Add(new(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 8.9));
        provas.Add(new(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 7.8));
        provas.Add(new(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Poções").Id, 5.9));
        provas.Add(new(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 6.9));
        provas.Add(new(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 7.5));
        provas.Add(new(alunos.Single(a => a.Name == "Ronald Weasley").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 6.8));
        provas.Add(new(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 7.1));
        provas.Add(new(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 7));
        provas.Add(new(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Poções").Id, 6.4));
        provas.Add(new(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 8));
        provas.Add(new(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 8.3));
        provas.Add(new(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 7.6));
        provas.Add(new(alunos.Single(a => a.Name == "Dino Thomas").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 7));
        provas.Add(new(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 6.9));
        provas.Add(new(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 7.3));
        provas.Add(new(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Poções").Id, 0));
        provas.Add(new(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 8.9));
        provas.Add(new(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 7.9));
        provas.Add(new(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 6.4));
        provas.Add(new(alunos.Single(a => a.Name == "Neville Longbottom").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 10));
        provas.Add(new(alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 7.4));
        provas.Add(new(alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 4.5));
        provas.Add(new(alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Poções").Id, 3.2));
        provas.Add(new(alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 8.7));
        provas.Add(new(alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 8.9));
        provas.Add(new(alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 7.8));
        provas.Add(new(alunos.Single(a => a.Name == "Simas Finnigan").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 5.4));
        provas.Add(new(alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 9));
        provas.Add(new(alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 8.5));
        provas.Add(new(alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Poções").Id, 8.9));
        provas.Add(new(alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 9.6));
        provas.Add(new(alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 8));
        provas.Add(new(alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 7.9));
        provas.Add(new(alunos.Single(a => a.Name == "Lilá Brown").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 6.4));
        provas.Add(new(alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 9.5));
        provas.Add(new(alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 9.1));
        provas.Add(new(alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Poções").Id, 8.9));
        provas.Add(new(alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 8.5));
        provas.Add(new(alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 6.4));
        provas.Add(new(alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 7.9));
        provas.Add(new(alunos.Single(a => a.Name == "Parvati Patil").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 5.5));
        provas.Add(new(alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Transfiguração").Id, 3.4));
        provas.Add(new(alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Feitiços").Id, 2));
        provas.Add(new(alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Poções").Id, 7));
        provas.Add(new(alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Historia da Magia").Id, 5.6));
        provas.Add(new(alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Defesa Contra as Artes das Trevas").Id, 4.7));
        provas.Add(new(alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Astronomia").Id, 7.8));
        provas.Add(new(alunos.Single(a => a.Name == "Fay Dunbar").Id, materias.Single(a => a.SubjectName == "Herbologia").Id, 8.1));


        context.Exams.AddRange(provas);
        context.SaveChanges();
    }
}
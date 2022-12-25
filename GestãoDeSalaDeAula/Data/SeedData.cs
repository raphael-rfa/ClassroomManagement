using GestãoDeSalaDeAula.Models;

namespace GestãoDeSalaDeAula.Data
{
    public static class SeedData
    {
        public static void Initialize(GestãoDeSalaDeAulaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Materias.Any())
            {
                return;//Banco de dados já foi semeado
            }           

            var materias = new Materias[]
            {
                new Materias {MateriasName = "Transfiguração"},
                new Materias {MateriasName = "Feitiços"},
                new Materias {MateriasName = "Poções"},
                new Materias {MateriasName = "Historia da Magia"},
                new Materias {MateriasName = "Defesa Contra as Artes das Trevas"},
                new Materias {MateriasName = "Astronomia"},
                new Materias {MateriasName = "Herbologia"}
            };

            foreach (Materias m in materias)
            {
                context.Materias.Add(m);
            }
            context.SaveChanges();

            var alunos = new Alunos[]
            {
                new Alunos { Name = "Hermione Granger"},
                new Alunos { Name = "Harry Potter"},
                new Alunos { Name = "Ronald Weasley"},
                new Alunos { Name = "Dino Thomas"},
                new Alunos { Name = "Neville Longbottom"},
                new Alunos { Name = "Simas Finnigan"},
                new Alunos { Name = "Lilá Brown"},
                new Alunos { Name = "Parvati Patil"},
                new Alunos { Name = "Fay Dunbar"},
                new Alunos { Name = "Kellah"}
            };

            foreach(Alunos aluno in alunos)
            {
                context.Alunos.Add(aluno);
            }
            context.SaveChanges();

            var provas = new Provas[]
            {
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Hermione Granger").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 9.1
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 9.8
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 4.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 6.3
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 8.7
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Harry Potter").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 8.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 8.9 
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 7.8
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 5.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 6.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 7.5
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Ronald Weasley").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 6.8
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 7.1
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 7
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 6.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 8
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 8.3
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 7.6
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Dino Thomas").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 7
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 6.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 7.3
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 0
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 8.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 7.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 6.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Neville Longbottom").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 10
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 7.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 4.5
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 3.2
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 8.7
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 8.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 7.8
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Simas Finnigan").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 5.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 8.5
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 8.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 9.6
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 8
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 7.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Lilá Brown").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 6.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 9.5
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 9.1
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 8.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 8.5
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 6.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 7.9
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Parvati Patil").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 5.5
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 3.4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 2
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 7
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 5.6
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 4.7
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 7.8
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Fay Dunbar").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 8.1
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Kellah").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Transfiguração").Id,
                    Nota = 5.3
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Kellah").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Feitiços").Id,
                    Nota = 7.6
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Kellah").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Poções").Id,
                    Nota = 8.3
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Kellah").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Historia da Magia").Id,
                    Nota = 3
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Kellah").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Defesa Contra as Artes das Trevas").Id,
                    Nota = 4
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Kellah").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Astronomia").Id,
                    Nota = 9.3
                },
                new Provas {
                    AlunosId = alunos.Single(a => a.Name == "Kellah").Id,
                    MateriasId = materias.Single(a => a.MateriasName == "Herbologia").Id,
                    Nota = 8
                }
            };

            foreach (Provas p in provas)
            {
                var ProvasNoBanco = context.Provas.Where(
                    s =>
                            s.Aluno.Id == p.AlunosId &&
                            s.Materia.Id == p.MateriasId).SingleOrDefault();
                if (ProvasNoBanco == null)
                {
                    context.Provas.Add(p);
                }
            }
            context.SaveChanges();
        }
    }
}
using GestãoDeSalaDeAula.Models;

namespace GestãoDeSalaDeAula.Data
{
    public static class SeedData
    {
        public static void Initialize(GestãoDeSalaDeAulaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
            {
                return;//Banco de dados já foi semeado
            }

            var aluno = new Aluno[]
            {
                new Aluno {Nome = "Hermione Granger"}
            };

            foreach (Aluno a in aluno)
            {
                context.Alunos.Add(a);
            }
            context.SaveChanges();

            var materias = new Materias[]
            {
                new Materias {MateriasName = "Transfiguração"},
                new Materias {MateriasName = "Feitiços"},
                new Materias {MateriasName = "Poções"},
                new Materias {MateriasName = "Historia da Magia"},
                new Materias {MateriasName = "Defesa Contra as Artes das Treevas"},
                new Materias {MateriasName = "Astronomia"},
                new Materias {MateriasName = "Herbologia"}
            };

            foreach (Materias m in materias)
            {
                context.Materias.Add(m);
            }
            context.SaveChanges();
        }
    }
}

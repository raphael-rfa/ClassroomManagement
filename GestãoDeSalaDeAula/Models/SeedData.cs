using GestãoDeSalaDeAula.Data;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeSalaDeAula.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new GestãoDeSalaDeAulaContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<GestãoDeSalaDeAulaContext>>()))
        {
            if(context.Aluno.Any())
            {
                return;
            }
            context.Aluno.AddRange(
            new Aluno() { Nome = "Harry Potter",
            Nota1 = 8.4D, Nota2 = 7.1D, Nota3 = 5.9D, Nota4 = 5.5D},
            
            new Aluno() { Nome = "Ronald Weasley",
            Nota1 = 7.9D, Nota2 = 5.9D, Nota3 = 6.3D, Nota4 = 5.7D},

            new Aluno() { Nome = "Hermione Granger",
            Nota1 = 10D, Nota2 = 10D, Nota3 = 10D, Nota4 = 10D}
            );
            context.SaveChanges();
        }
    }
}

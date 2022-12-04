using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestãoDeSalaDeAula.Models;

namespace GestãoDeSalaDeAula.Data
{
    public class GestãoDeSalaDeAulaContext : DbContext
    {
        public GestãoDeSalaDeAulaContext (DbContextOptions<GestãoDeSalaDeAulaContext> options)
            : base(options)
        {
        }

        public DbSet<GestãoDeSalaDeAula.Models.Aluno> Aluno { get; set; } = default!;
    }
}

using AwesomeGymAPI.Models;
using AwesomeGymAPI.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymAPI.Persistence
{
    public class AwesomeDbContext : DbContext
    {
        public AwesomeDbContext(DbContextOptions<AwesomeDbContext> options)
            :base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AlunoConfiguration());
            builder.ApplyConfiguration(new UnidadeConfiguration());
            builder.ApplyConfiguration(new ProfessorConfiguration());
        }

    }
}

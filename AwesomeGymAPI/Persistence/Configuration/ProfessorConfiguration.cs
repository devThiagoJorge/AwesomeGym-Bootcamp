using AwesomeGymAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymAPI.Persistence.Configuration
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Endereco)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.HasMany(x => x.Alunos)
                .WithOne(x => x.Professor)
                .HasForeignKey(x => x.IdProfessor)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

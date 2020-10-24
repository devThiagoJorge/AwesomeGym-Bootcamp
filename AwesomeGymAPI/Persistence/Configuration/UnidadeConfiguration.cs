using AwesomeGymAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymAPI.Persistence.Configuration
{
    public class UnidadeConfiguration : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.ToTable("Unidade");
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.Property(x => x.Endereco)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            // Uma unidade tem muitos alunos
            // 1 - N
            builder.HasMany(x => x.Alunos)
                .WithOne(u => u.Unidade)
                .HasForeignKey(a => a.IdUnidade)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Professores)
                .WithOne(x => x.Unidade)
                .HasForeignKey(x => x.IdUnidade)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

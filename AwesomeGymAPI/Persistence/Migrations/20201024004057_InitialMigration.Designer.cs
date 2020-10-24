﻿// <auto-generated />
using System;
using AwesomeGymAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AwesomeGymAPI.Persistence.Migrations
{
    [DbContext(typeof(AwesomeDbContext))]
    [Migration("20201024004057_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AwesomeGymAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNasicmento")
                        .HasColumnType("date");

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("IdProfessor")
                        .HasColumnType("int");

                    b.Property<int>("IdUnidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProfessor");

                    b.HasIndex("IdUnidade");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("AwesomeGymAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("IdUnidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUnidade");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("AwesomeGymAPI.Models.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("AwesomeGymAPI.Models.Aluno", b =>
                {
                    b.HasOne("AwesomeGymAPI.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("IdProfessor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AwesomeGymAPI.Models.Unidade", "Unidade")
                        .WithMany("Alunos")
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("AwesomeGymAPI.Models.Professor", b =>
                {
                    b.HasOne("AwesomeGymAPI.Models.Unidade", "Unidade")
                        .WithMany("Professores")
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Bidor.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bidor.Dados.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211115033359_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bidor.Dados.Entidades.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Bidor.Dados.Entidades.Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataDaAtividade")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<float>("PontosObtidos")
                        .HasColumnType("real");

                    b.Property<int?>("TipoDeAtividadeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TipoDeAtividadeId");

                    b.ToTable("Atividade");
                });

            modelBuilder.Entity("Bidor.Dados.Entidades.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("Bidor.Dados.Entidades.TipoDeAtividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoDeAtividade");
                });

            modelBuilder.Entity("Bidor.Dados.Entidades.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Ano")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.Property<short>("Semestre")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("Bidor.Dados.Entidades.Atividade", b =>
                {
                    b.HasOne("Bidor.Dados.Entidades.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.HasOne("Bidor.Dados.Entidades.TipoDeAtividade", "TipoDeAtividade")
                        .WithMany()
                        .HasForeignKey("TipoDeAtividadeId");

                    b.Navigation("Aluno");

                    b.Navigation("TipoDeAtividade");
                });

            modelBuilder.Entity("Bidor.Dados.Entidades.Turma", b =>
                {
                    b.HasOne("Bidor.Dados.Entidades.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId");

                    b.Navigation("Materia");
                });
#pragma warning restore 612, 618
        }
    }
}

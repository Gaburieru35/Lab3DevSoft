﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaMoedas.Data;

#nullable disable

namespace SistemaMoedas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241105180346_attDb")]
    partial class attDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaMoedas.Classes.Aluno", b =>
                {
                    b.Property<int>("CodigoAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoAluno"));

                    b.Property<string>("CpfAluno")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR")
                        .HasColumnOrder(3);

                    b.Property<int>("CursoAluno")
                        .HasColumnType("int")
                        .HasColumnOrder(10);

                    b.Property<DateTime>("DataCadastroAluno")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(8);

                    b.Property<string>("EmailAluno")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnOrder(1);

                    b.Property<string>("EnderecoAluno")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnOrder(2);

                    b.Property<int>("InstituicaoAluno")
                        .HasColumnType("int")
                        .HasColumnOrder(9);

                    b.Property<string>("NomeAluno")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnOrder(5);

                    b.Property<int>("QuantidadeMoedasAluno")
                        .HasColumnType("int")
                        .HasColumnOrder(7);

                    b.Property<string>("RGAluno")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("VARCHAR")
                        .HasColumnOrder(4);

                    b.Property<string>("SenhaAluno")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnOrder(6);

                    b.HasKey("CodigoAluno");

                    b.ToTable("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
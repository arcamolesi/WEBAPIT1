﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBAPIT1;

#nullable disable

namespace WEBAPIT1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240503225240_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WEBAPIT1.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("disciplina")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("nome")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<float>("nota1")
                        .HasColumnType("real");

                    b.Property<float>("nota2")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
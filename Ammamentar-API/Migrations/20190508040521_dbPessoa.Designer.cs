﻿// <auto-generated />
using Ammamentar.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ammamentar.API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190508040521_dbPessoa")]
    partial class dbPessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("Ammamentar.API.Model.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("celular");

                    b.Property<string>("cpf");

                    b.Property<string>("email");

                    b.Property<string>("endereco");

                    b.Property<string>("nome");

                    b.Property<string>("numero");

                    b.Property<int>("registroAtivo");

                    b.Property<string>("rg");

                    b.Property<string>("rua");

                    b.Property<string>("senha");

                    b.Property<string>("telefone");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}

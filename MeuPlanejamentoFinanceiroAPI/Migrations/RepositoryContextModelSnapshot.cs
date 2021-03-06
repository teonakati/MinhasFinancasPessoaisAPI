﻿// <auto-generated />
using System;
using MeuPlanejamentoFinanceiroRepository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeuPlanejamentoFinanceiroAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeuPlanejamentoFinanceiroDomain.Models.Gasto", b =>
                {
                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PessoaCpf")
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime");

                    b.Property<int>("QuantidadeMeses")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Descricao", "PessoaCpf");

                    b.HasIndex("PessoaCpf");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("MeuPlanejamentoFinanceiroDomain.Models.Pessoa", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Senha")
                        .HasColumnType("varchar(15)");

                    b.HasKey("Cpf");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("MeuPlanejamentoFinanceiroDomain.Models.Gasto", b =>
                {
                    b.HasOne("MeuPlanejamentoFinanceiroDomain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaCpf")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}

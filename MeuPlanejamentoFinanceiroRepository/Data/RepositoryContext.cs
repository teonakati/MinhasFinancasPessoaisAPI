using MeuPlanejamentoFinanceiroDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPlanejamentoFinanceiroRepository.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Gasto>()
                .HasKey(e => new { e.Descricao, e.PessoaCpf });
                
        }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
    }
}

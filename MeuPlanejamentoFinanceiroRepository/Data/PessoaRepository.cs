using MeuPlanejamentoFinanceiroDomain.Models;
using MeuPlanejamentoFinanceiroService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPlanejamentoFinanceiroRepository.Data
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}

using MeuPlanejamentoFinanceiroDomain.Models;
using MeuPlanejamentoFinanceiroService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPlanejamentoFinanceiroRepository.Data
{
    public class GastoRepository : RepositoryBase<Gasto>, IGastoRepository
    {
        public GastoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}

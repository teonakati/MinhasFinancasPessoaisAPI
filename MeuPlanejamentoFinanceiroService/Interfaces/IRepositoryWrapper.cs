using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPlanejamentoFinanceiroService.Interfaces
{
    public interface IRepositoryWrapper
    {
        IPessoaRepository Pessoa { get; }
        IGastoRepository Gasto { get; }
        void Save();
    }
}

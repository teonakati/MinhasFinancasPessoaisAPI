using MeuPlanejamentoFinanceiroService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPlanejamentoFinanceiroRepository.Data
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IPessoaRepository _pessoa;
        private IGastoRepository _gasto;
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public IPessoaRepository Pessoa
        {
            get
            {
                if (_pessoa == null)
                {
                    _pessoa = new PessoaRepository(_repoContext);
                }
                return _pessoa;
            }
        }
        public IGastoRepository Gasto
        {
            get
            {
                if (_gasto == null)
                {
                    _gasto = new GastoRepository(_repoContext);
                }
                return _gasto;
            }
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}

using MeuPlanejamentoFinanceiroDomain.Models;
using MeuPlanejamentoFinanceiroRepository.Data;
using MeuPlanejamentoFinanceiroRepository.Dto;
using MeuPlanejamentoFinanceiroService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPlanejamentoFinanceiroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public PessoaController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        
        [HttpGet]
        public IActionResult GetAllPessoas()
        {
            return Ok(_repositoryWrapper.Pessoa.GetAll());
        }

        [HttpPost]
        public IActionResult InsertPessoa([FromBody] DtoPessoa dto)
        {

            var pessoa = new Pessoa(dto.Cpf, dto.Nome, dto.DataNascimento, dto.Email, dto.Senha);

            _repositoryWrapper.Pessoa.Insert(pessoa);
            _repositoryWrapper.Save();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePessoa([FromBody] DtoPessoa dto)
        {
            var pessoa = _repositoryWrapper.Pessoa.Find(dto.Cpf);
            pessoa.Nome = dto.Nome;
            pessoa.DataNascimento = dto.DataNascimento;
            pessoa.Email = dto.Email;
            pessoa.Senha = dto.Senha;

            _repositoryWrapper.Pessoa.Update(pessoa);
            _repositoryWrapper.Save();

            return Ok();
        }

        [HttpDelete("{cpf}")]
        public IActionResult DeletePessoa(string cpf)
        {
            var pessoa = _repositoryWrapper.Pessoa.Find(cpf);
            _repositoryWrapper.Pessoa.Delete(pessoa);
            _repositoryWrapper.Save();
            return Ok();
        }
    }
}

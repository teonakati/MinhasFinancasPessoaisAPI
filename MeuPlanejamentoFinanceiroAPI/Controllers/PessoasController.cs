using MeuPlanejamentoFinanceiroDomain.Models;
using MeuPlanejamentoFinanceiroRepository.Data;
using MeuPlanejamentoFinanceiroRepository.Dto;
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
    public class PessoasController : ControllerBase
    {
        private readonly RepositoryContext _context;
        public PessoasController(RepositoryContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAllPessoas()
        {
            return Ok(_context.Pessoas.AsNoTracking());
        }

        [HttpPost]
        public IActionResult InsertPessoa([FromBody] DtoPessoa dto)
        {

            var pessoa = new Pessoa(dto.Cpf, dto.Nome, dto.DataNascimento, dto.Email, dto.Senha);

            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();

            return Ok();
        }
    }
}

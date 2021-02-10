using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPlanejamentoFinanceiroRepository.Dto
{
    public class DtoPessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MeuPlanejamentoFinanceiroDomain.Models
{
    public class Pessoa
    {
        public Pessoa(){}
        public Pessoa(string cpf, string nome, DateTime dataNascimento, string email, string senha)
        {
            Cpf = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Senha = senha;
        }

        [Key]
        [Column(TypeName = "varchar(11)")]
        public string Cpf { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column(TypeName ="datetime")]
        public DateTime DataNascimento { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Senha { get; set; }
    }
}

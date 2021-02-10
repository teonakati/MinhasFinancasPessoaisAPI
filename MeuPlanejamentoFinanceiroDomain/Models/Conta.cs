using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MeuPlanejamentoFinanceiroDomain.Models
{
    public class Gasto
    {
        [Column(TypeName ="varchar(50)")]
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeMeses { get; set; }
        [Column(TypeName ="datetime")]
        public DateTime DataInicio { get; set; }
        public string PessoaCpf { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}

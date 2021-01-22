using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudo.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public string Marca { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataLancamento { get; set; }

        public TipoProduto TipoDeProduto { get; set; }       

        
    }
}

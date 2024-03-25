using System.ComponentModel.DataAnnotations;

namespace ListaDeProdutos.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do produto.")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "Digite a descrição do produto.")]
        public string Descricao { get; set; } = "";

        [Required(ErrorMessage = "Digite o valor do produto.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe a disponibilidade")]
        public bool Disponivel { get; set; }

        public DateTime Data { get; set; }
    }
}

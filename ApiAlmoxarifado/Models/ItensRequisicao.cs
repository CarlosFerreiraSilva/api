using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class ItensRequisicao
    {
        [Key]
        public int codigo { get; set; }
        public Requisicao requisicao { get; set; }
        public int codigoRequisicao { get; set; }
        public Produto produto { get; set; }
        public int codigoProduto { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
    }
}

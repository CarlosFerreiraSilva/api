using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class ItensEntrada
    {
        [Key]
        public int Codigo { get; set; }
        public int codigoEntrada { get; set; }
        public Entrada entrada { get; set; }
        public Produto produto { get; set; }
        public int codigoProduto { get; set; }
        public int estoque { get; set; }
    }
}

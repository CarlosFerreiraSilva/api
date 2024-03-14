using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class Entrada
    {
        [Key]
        public int codigo { get; set; }
        public DateTime dataEntrada { get; set; }
        public List<ItensEntrada> produto { get; set; }
    }
}

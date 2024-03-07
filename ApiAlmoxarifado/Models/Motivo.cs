using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class Motivo
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int CodigoCategoriaMotivo { get; set; }
        public CategoriaMotivo CategoriaMotivo { get; set; }

    }
}

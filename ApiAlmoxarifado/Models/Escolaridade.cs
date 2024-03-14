using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class Escolaridade
    {
        [Key]
        public int codigo { get; set; }
        public string descricao { get; set; }

    }
}

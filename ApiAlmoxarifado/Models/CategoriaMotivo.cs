﻿using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class CategoriaMotivo
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public List<Motivo> Motivos { get; set; }
    }
}

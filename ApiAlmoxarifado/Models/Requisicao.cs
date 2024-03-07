using System.ComponentModel.DataAnnotations;

namespace ApiAlmoxarifado.Models
{
    public class Requisicao
    {
        [Key]
        public int Codigo { get; set; }
        public DateTime DataRequisicao { get; set; }
        public Departamento departamento { get; set; }
        public Funcionario funcionario { get; set; }
        public List<ItensRequisicao> itens { get; set; }
    } 
}

namespace ApiAlmoxarifado.Models
{
    public class Entrada
    {
        public int codigo { get; set; }
        public DateTime dataEntrada { get; set; }
        public Produto produto { get; set; }
    }
}

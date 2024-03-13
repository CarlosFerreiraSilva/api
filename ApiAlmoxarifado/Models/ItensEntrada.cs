namespace ApiAlmoxarifado.Models
{
    public class ItensEntrada
    {
        public int Codigo { get; set; }
        public Entrada codigoEntrada { get; set; }
        public Produto codigoProduto { get; set; }
        public int estoque { get; set; }
        public int entrada_id { get; set; }
    }
}

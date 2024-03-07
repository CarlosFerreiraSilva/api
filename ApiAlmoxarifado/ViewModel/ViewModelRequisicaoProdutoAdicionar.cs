using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.ViewModel
{
    public class ViewModelRequisicaoProdutoAdicionar
    {
        public int codigoDepartamento { get; set; }
        public int codigoFuncionario { get; set; }
        public List<ItensRequisicao> itens { get; set; }
    }
}

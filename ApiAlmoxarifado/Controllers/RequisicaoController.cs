using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/requisicao")]
    public class RequisicaoController : Controller
    {

        [HttpPost]
        [Route("AdicionarRequisicao")]
        public IActionResult AdicionarRequisicao(ViewModelRequisicaoProdutoAdicionar carrinho)
        {
            var requisicao = new Requisicao()
            {
                DataRequisicao = DateTime.Now,
                departamento = new Departamento() { depid = carrinho.codigoDepartamento },
                itens = carrinho.itens
            };
            return View();
        }
    }
}

using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/itensentrada")]
    public class ItensEntradaController : Controller
    {
        private readonly IItensEntradaRepository _itensentradaRepository;

        public ItensEntradaController(IItensEntradaRepository departamentoRepository)
        {
            _itensentradaRepository = departamentoRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_itensentradaRepository.GetAll());
        }

        [HttpGet]
        [Route("{id}/GetItensEntrada")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_itensentradaRepository.GetAll().Find(x => x.Codigo == id));
        }

        [HttpPut]
        [Route("GetItensEntradaUpdate")]
        public IActionResult CategoriaUpdate(ItensEntrada categoria)
        {
            _itensentradaRepository.Update(categoria);
            return Ok("Sucesso");
        }


        [HttpDelete]
        [Route("DeletarItensEntrada")]
        public IActionResult DeletarDepartamento(int produto)
        {
            var categoria = _itensentradaRepository.GetAll().Find(x => x.Codigo == produto);

            _itensentradaRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarItensEntrada")]
        public IActionResult AdicionarDepartamento(ItensEntrada produto)
        {
            try
            {
                _itensentradaRepository.Add
                (
                new ItensEntrada()
                {
                    Codigo = produto.Codigo,
                    codigoEntrada = produto.codigoEntrada,
                    estoque = produto.estoque,
                    codigoProduto = produto.codigoProduto,
                    entrada_id = produto.entrada_id
                }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro" + ex.Message);
            }

        }

    }
}

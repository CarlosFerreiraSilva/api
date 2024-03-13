using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;
using ApiAlmoxarifado.ViewModel;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/entrada")]
    public class EntradaController:Controller
    {
        private readonly IEntradaRepository _entradaRepository;

        public EntradaController(IEntradaRepository categoriaRepository)
        {
            _entradaRepository = categoriaRepository;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_entradaRepository.GetAll());
        }



        [HttpGet]
        [Route("{id}/GetCategoriaMotivo")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_entradaRepository.GetAll().Find(x => x.codigo == id));
        }

        [HttpPut]
        [Route("GetCategoriaMotivoUpdate")]
        public IActionResult Update(Entrada categoria)
        {
            _entradaRepository.Update(categoria);
            return Ok("Sucesso");
        }



        [HttpDelete]
        [Route("DeletarCategoriaMotivo")]
        public IActionResult DeletarProdutoSemFoto(int produto)
        {
            var categoria = _entradaRepository.GetAll().Find(x => x.codigo == produto);

            _entradaRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarCategoriaMotivo")]
        public IActionResult AdicionarCategoria(Entrada produto)
        {
            try
            {
                _entradaRepository.Add
                (
                new Entrada() { dataEntrada = produto.dataEntrada, produto = produto.produto }
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

using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/departamento")]
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoController(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_departamentoRepository.GetAll());
        }

        [HttpPost]
        [Route("AdicionarDepartamento")]
        public IActionResult AdicionarDepartamento(Departamento produto)
        {
            try
            {
                _departamentoRepository.Add
                (
                new Departamento() { descricao = produto.descricao, ativado = produto.ativado}
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

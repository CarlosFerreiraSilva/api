using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/escolaridade")]
    public class EscolaridadeController : Controller
    {
        private readonly IEscolaridadeRepository _escolaridadeRepository;

        public EscolaridadeController(IEscolaridadeRepository funcionarioRepository)
        {
            _escolaridadeRepository = funcionarioRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_escolaridadeRepository.GetAll());
        }


        [HttpGet]
        [Route("{id}/GetFuncionario")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_escolaridadeRepository.GetAll().Find(x => x.codigo == id));
        }

        [HttpPut]
        [Route("GetFuncionarioUpdate")]
        public IActionResult Update(Escolaridade categoria)
        {
            _escolaridadeRepository.Update(categoria);
            return Ok("Sucesso");
        }

        [HttpDelete]
        [Route("DeletarCategoria")]
        public IActionResult DeletarDepartamento(int produto)
        {
            var categoria = _escolaridadeRepository.GetAll().Find(x => x.codigo == produto);

            _escolaridadeRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarDepartamento")]
        public IActionResult AdicionarFuncionario(Escolaridade funcionario)
        {
            try
            {
                _escolaridadeRepository.Add
                (
                new Escolaridade()
                {
                    codigo= funcionario.codigo,
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

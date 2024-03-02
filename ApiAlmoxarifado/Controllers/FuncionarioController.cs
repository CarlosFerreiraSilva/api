using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_funcionarioRepository.GetAll());
        }

        [HttpPost]
        [Route("AdicionarDepartamento")]
        public IActionResult AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                _funcionarioRepository.Add
                (
                new Funcionario() { nome = funcionario.nome, cargo = funcionario.cargo, dataNascimento = funcionario.dataNascimento,
                    salario = funcionario.salario, endereço = funcionario.endereço, cidade = funcionario.cidade, uf = funcionario.uf }
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

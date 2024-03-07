using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/motivo")]
    public class MotivoController : Controller
    {
        private readonly IMotivo _motivoRepository;

        [HttpPost]
        [Route("Adicionar")]
        public IActionResult Adicionar(MotivoViewModel pMotivo)
        {
            try { 
            var novoMotivo = new Motivo()
            {
            Descricao = pMotivo.Descricao,
            CodigoCategoriaMotivo = 1
            };

            _motivoRepository.Add(novoMotivo);
            return Ok("Cadastrado com sucesso");

            }
            catch (Exception ex)
            {

                return Ok("Não cadastro" + ex.Message);
            }


        }
    }
   
    }
}

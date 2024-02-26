using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        [Route("Hello")]
        public IActionResult Hello()
        {
            return Ok("Hello Mundo");
        }

        [HttpGet]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var categoria = new List<Categoria>();
            {
                new Categoria()
                {
                    categoriaid = 1,
                    descricao = "pereciveis",
                };
                new Categoria()
                {
                    categoriaid = 2,
                    descricao = "não pereciveis",
                };
            };
            return Ok(categoria);

        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_categoriaRepository.GetAll());
        }



        [HttpGet]
        [Route("{id}/GetCategoria")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_categoriaRepository.GetAll().Find(x => x.categoriaid == id));
        }

        [HttpPost]
        [Route("AdicionarCategoria")]
        public IActionResult AdicionarCategoria(Categoria produto)
        {
            try
            {
                _categoriaRepository.Add
                (
                new Categoria() { descricao = produto.descricao}
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

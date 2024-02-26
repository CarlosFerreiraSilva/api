using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
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
            var produtos = new List<Produto>();
            {
                new Produto()
                {
                    id = 1,
                    nome = "PC HP",
                    estoque = 10
                };
                new Produto()
                {
                    id = 2,
                    nome = "PC DELL",
                    estoque = 20
                };
            };
            return Ok(produtos);

        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_produtoRepository.GetAll());
        }

        [HttpPost]
        [Route("AdicionarProdutoSemFoto")]
        public IActionResult AdicionarProdutoSemFoto(ProdutoViewModelSemFoto produto)
        {
            try
            {
                _produtoRepository.Add
                (
                new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro" + ex.Message);
            }

        }

        //[HttpPost]
        //[Route("AdicionarProdutoSemFoto")]
        //public IActionResult AdicionarProdutoComFoto([FromForm] ProdutoViewModelComFoto produto)
        //{
        //    try
        //    {
        //        var caminho = Path.Combine("Storage", produto.photourl.FileName);
        //        using Stream fileStream = new FileStream(caminho, FileMode.Create);
        //        produto.photourl.CopyTo(fileStream);
        //        _produtoRepository.Add
        //        (
        //        new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = caminho }
        //        );

        //        return Ok("Cadastrado com Sucesso");
        //    }
        //    catch (Exception ex)
        //    {

        //        return BadRequest("Não Cadastrado. Erro" + ex.Message);
        //    }

        //}

        [HttpGet]
        [Route("{id}/GetProduto")]
        public IActionResult GetProduto(int id)
        {
            return Ok(_produtoRepository.GetAll().Find(x => x.id == id));
        }

        [HttpGet]
        [Route("{id}/Download")]
        public IActionResult Download(int id)
        {
            try
            {
                var produto = _produtoRepository.GetAll().Find(x => x.id == id);
                if (produto.photourl == null)
                {
                    return Ok("Não existe faalta cadastrada para o Produto");
                }
                else
                {
                    var dataBytes = System.IO.File.ReadAllBytes(produto.photourl);
                    return File(dataBytes, "img/jpg");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Erro em fazer download: " + ex.Message);
                throw;
            }
        }
    }
}


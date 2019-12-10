using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCrm.Models.Repository;


namespace WebApiCrm.Controllers.Cliente
{

    //[Route("api/V{version:apiVersion}/[controller]")]
    [ApiController]    
    public class ClienteController: ControllerBase
    {
        private readonly IClienteRepository Repositorio;

        public ClienteController(IClienteRepository repositorio)
        {
            Repositorio = repositorio;
        }

        //[HttpPost]
        //[ApiVersion("1.0")]
        //public IActionResult Criar([FromBody]Cliente cliente)
        //{
        //    if (cliente. == "")
        //        return BadRequest("Nome não informado!");

        //    if (string.IsNullOrEmpty(cliente.))
        //        return BadRequest("Descrição do Produto não informado!");

        //    Repositorio.Iserir(produto);

        //    return Created(nameof(Criar), cliente);
        //}
        

        //[HttpGet]
        //[ApiVersion("1.0")]
        //[ResponseCache(Duration =15)]
        //public IActionResult Obter()
        //{
        //    var lista = Repositorio.Obter();

        //    return Ok(lista);
        //}
        
        //[HttpGet("{Chave_Id}")]
        //[ApiVersion("1.0")]
        //public IActionResult Obter(int Chave_Id)
        //{
        //    var produto = Repositorio.Obter(Chave_Id);

        //    if (produto == null) return NotFound();

        //    return Ok(produto);
        //}
        
        //[HttpPut]
        //[ApiVersion("1.0")]
        //public IActionResult Atualizar([FromBody]Produto produto)
        //{
        //    var prod = Repositorio.Obter(produto.Chave_Id);

        //    if (prod == null) return NotFound();

        //    if (produto.Codigo == "")
        //        return BadRequest("Código do Produto não informado!");

        //    if (string.IsNullOrEmpty(produto.Descricao))
        //        return BadRequest("Descrição do Produto não informado!");

        //    Repositorio.Editar(produto);

        //    return NoContent();
        //}
        
        //[HttpDelete("{Chave_Id}")]
        //[ApiVersion("1.0")]
        //public IActionResult Apagar(int Chave_Id)
        //{
        //    var produto = Repositorio.Obter(Chave_Id);

        //    if (produto == null) return NotFound();

        //    Repositorio.Excluir(produto);

        //    return Ok();
        //}

        //[HttpGet("{codigo}")]
        //[ApiVersion("2.0")]
        //public IActionResult ObterPorCodigo(string codigo)
        //{
        //    var produto = Repositorio.Obter();

        //    if (produto == null) return NotFound();

        //    return Ok(produto);
        //}

        //[HttpGet("")]
        //[ApiVersion("3.0")]
        //public IActionResult ObterTodos()
        //{
        //    var produto = Repositorio.Obter();

        //    if (produto == null) return NotFound();

        //    return Ok( "Verão 3 " );
        //}
    }
}

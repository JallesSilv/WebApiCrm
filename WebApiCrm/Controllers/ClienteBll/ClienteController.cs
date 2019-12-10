using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiCrm.Models.Repository;
using WebApiCrm.Models.Entidades;
using System.Collections.Generic;

namespace WebApiCrm.Controllers.ClienteBll
{

    [Route("api/V{version:apiVersion}/[controller]")]
    [ApiController]    
    public class ClienteController: ControllerBase
    {
        private readonly IClienteRepository Repository;

        public ClienteController(IClienteRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        [ApiVersion("1.0")]
        [ResponseCache(Duration = 60)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var lista = Repository.Obter();

            return Ok(lista);
        }

        [HttpGet("{Chave_Id}")]
        [ApiVersion("1.0")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get(int Chave_Id)
        {
            var cliente = Repository.Obter(Chave_Id);

            if (cliente == null) return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        [ApiVersion("1.0")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Post([FromBody]Cliente cliente)
        {
            Repository.Iserir(cliente);

            return Created(nameof(Post), cliente);
        }

        [HttpPut]
        [ApiVersion("1.0")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(Cliente cliente)
        {
            var cli = Repository.Obter(cliente.Chave_Cliente);

            if (cli == null) return NotFound();

            Repository.Editar(cliente);

            return Ok();
        }

        [HttpDelete("{Chave_Cliente}")]
        [ApiVersion("1.0")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete(int Chave_Cliente)
        {
            var cliente = Repository.Obter(Chave_Cliente);

            if (cliente == null) return NotFound();

            Repository.Excluir(cliente);
            return Ok();
        }

        [HttpGet("{codigo}")]
        [ApiVersion("2.0")]
        public IActionResult GetV2(int Chave_Cliente)
        {
            return Ok("Versao 2.0");
        }

        [HttpGet("")]
        [ApiVersion("3.0")]
        public IActionResult GetCompressao()
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < 1000; i++)
                lista.Add($"item:{i}");

            return Ok($"Versao 3.0: {string.Join(",", lista)}");
        }
    }
}

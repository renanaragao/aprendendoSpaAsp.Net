using Jil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class PessoaController : ApiController
    {

        [Route("saidas/")]
        [DeflateCompressionAtribute]
        [HttpGet]
        public IHttpActionResult Pesquisar()
        {

            var pessoas = new List<Pessoa>();

            for (int i = 0; i < 1000; i++)
            {
                pessoas.Add(new Pessoa()
                {
                    Codigo = Guid.NewGuid(),
                    Nome = "Nome" + (i + 1)
                });
            }

            return Ok(pessoas);

        }

        [Route("saidas/semcompressao")]
        [HttpGet]
        public IHttpActionResult PesquisarSemCompressao()
        {

            var pessoas = new List<Pessoa>();

            for (int i = 0; i < 1000; i++)
            {
                pessoas.Add(new Pessoa()
                {
                    Codigo = Guid.NewGuid(),
                    Nome = "Nome" + (i + 1)
                });
            }

            return Ok(pessoas);

        }

    }

    public class Pessoa
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
    }
}

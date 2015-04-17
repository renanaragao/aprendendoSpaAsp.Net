using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class PessoaController : ApiController
    {

        [Route("saidas/")]
        [HttpGet]
        public IHttpActionResult Pesquisar()
        {

            var pessoas = new List<Pessoa>();

            for (int i = 0; i < 4; i++)
            {
                pessoas.Add(new Pessoa()
                {
                    Codigo = Guid.NewGuid(),
                    Nome = "Nome" + (i + 1)
                });
            }

            return Ok(pessoas.OrderBy(x => x.Codigo));

        }

    }

    public class Pessoa
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
    }
}

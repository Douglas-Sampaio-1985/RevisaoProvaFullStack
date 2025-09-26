using Microsoft.AspNetCore.Mvc;
using Gestao.Dominio;
using Gestao.Servico;

namespace Gestao.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _servico;

        public AlunoController(IAlunoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _servico.Adicionar(aluno);
            return Ok("Aluno cadastrado com sucesso!");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servico.Listar());
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            _servico.Atualizar(aluno);
            return Ok("Aluno atualizado com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servico.Remover(id);
            return Ok("Aluno removido com sucesso!");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;

namespace TesteDesenvolvedor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscricaoController : ControllerBase
    {
        private readonly IInscricaoService _service;
        public InscricaoController(IInscricaoService service)
        {
            _service = service;
        }

        [HttpGet]
        [EndpointSummary("Exibe todas as inscrições cadastradas cadastradas.")]
        public async Task<IActionResult> GetAll()
        {
            var inscricoes = await _service.GetAll();

            return Ok(inscricoes);
        }

        [HttpGet("{id}")]
        [EndpointSummary("Exibe a incrição correspondente ao Id filtrado.")]
        public async Task<IActionResult> GetById(int id)
        {
            var inscricao = await _service.GetById(id);

            return Ok(inscricao);
        }

        [HttpPost]
        [EndpointSummary("Permite o cadastro de uma nova inscrição.")]
        public async Task<IActionResult> Create([FromBody] InscricaoDTO inscricao)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Add(inscricao);

            return CreatedAtAction(nameof(GetById), new { id = inscricao.Id }, inscricao);
        }

        [HttpPut]
        [EndpointSummary("Permite a edição de dados de uma inscrição existente.")]
        public async Task<IActionResult> Update(int id, [FromBody] InscricaoDTO inscricao)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Update(inscricao);

            return Ok(inscricao);
        }

        [HttpDelete("{id}")]
        [EndpointSummary("Permite a deleção de uma inscrição filtrado pelo Id.")]
        public async Task<IActionResult> Delete(int id)
        {
            var inscricao = await _service.GetById(id);

            await _service.Delete(id);

            return Ok(inscricao);
        }

        [HttpGet("by-cpf/{cpf}")]
        [EndpointSummary("Exibe todas as incrições correspondente ao CPF do lead/candidato filtrado.")]
        public async Task<IActionResult> GetByCpf(string cpf)
        {
            var inscricoes = await _service.GetByCpf(cpf);

            return Ok(inscricoes);
        }

        [HttpGet("by-ofeta/{ofertaId}")]
        [EndpointSummary("Exibe todas as incrições correspondente ao id do curso/oferta filtrado.")]
        public async Task<IActionResult> GetByOferta(int ofertaId)
        {
            var inscricoes = await _service.GetByOferta(ofertaId);

            return Ok(inscricoes);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;

namespace TesteDesenvolvedor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly ILeadService _service;
        public LeadController(ILeadService service)
        {
            _service = service;
        }

        [HttpGet]
        [EndpointSummary("Exibe todos os leads/candidatos cadastrados.")]
        public async Task<IActionResult> GetAll()
        {
            var leads = await _service.GetAll();

            return Ok(leads);
        }

        [HttpGet("{id}")]
        [EndpointSummary("Exibe o leads/candidatos correspondente ao Id filtrado.")]
        public async Task<IActionResult> GetById(int id)
        {
            var lead = await _service.GetById(id);

            return Ok(lead);
        }

        [HttpPost]
        [EndpointSummary("Permite o cadastro de um lead/candidato.")]
        public async Task<IActionResult> Create([FromBody] LeadDTO lead)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Add(lead);

            return CreatedAtAction(nameof(GetById), new { id = lead.Id }, lead);
        }

        [HttpPut]
        [EndpointSummary("Permite a edição de dados de um lead/candidato existente.")]
        public async Task<IActionResult> Update(int id, [FromBody] LeadDTO lead)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Update(lead);

            return Ok(lead);
        }

        [HttpDelete("{id}")]
        [EndpointSummary("Permite a deleção de um lead/candidato filtrado pelo Id.")]
        public async Task<IActionResult> Delete(int id)
        {
            var lead = await _service.GetById(id);

            await _service.Delete(id);

            return Ok(lead);
        }
    }
}

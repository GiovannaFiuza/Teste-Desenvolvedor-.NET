using Microsoft.AspNetCore.Mvc;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;


namespace TesteDesenvolvedor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        private readonly IOfertaService _service;
        public OfertaController(IOfertaService service)
        {
            _service = service;
        }

        [HttpGet]
        [EndpointSummary("Exibe todos as oferta/curso cadastrados.")]
        public async Task<IActionResult> GetAll()
        {
            var ofertas = await _service.GetAll();

            return Ok(ofertas);
        }

        [HttpGet("{id}")]
        [EndpointSummary("Exibe a oferta/curso correspondente ao Id filtrado.")]
        public async Task<IActionResult> GetById(int id)
        {
            var oferta = await _service.GetById(id);

            return Ok(oferta);
        }

        [HttpPost]
        [EndpointSummary("Permite o cadastro de uma oferta/curso.")]
        public async Task<IActionResult> Create([FromBody] OfertaDTO oferta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Add(oferta);

            return CreatedAtAction(nameof(GetById), new { id = oferta.Id }, oferta);
        }

        [HttpPut]
        [EndpointSummary("Permite a edição de dados de uma oferta/curso existente.")]
        public async Task<IActionResult> Update(int id, [FromBody] OfertaDTO oferta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Update(oferta);

            return Ok(oferta);
        }

        [HttpDelete("{id}")]
        [EndpointSummary("Permite a deleção de uma oferta/curso filtrado pelo Id.")]
        public async Task<IActionResult> Delete(int id)
        {
            var oferta = await _service.GetById(id);

            await _service.Delete(id);

            return Ok(oferta);
        }
    }
}

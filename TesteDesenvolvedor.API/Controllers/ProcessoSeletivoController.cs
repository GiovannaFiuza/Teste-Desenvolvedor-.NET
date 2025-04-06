using Microsoft.AspNetCore.Mvc;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;


namespace TesteDesenvolvedor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessoSeletivoController : ControllerBase
    {
        private readonly IProcessoSeletivoService _service;
        public ProcessoSeletivoController(IProcessoSeletivoService service)
        {
            _service = service;
        }

        [HttpGet]
        [EndpointSummary("Exibe todos os processos seletivos cadastrados.")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAll();

            return Ok(result);
        }

        [HttpGet("{id}")]
        [EndpointSummary("Exibe o processo seletivo correspondente ao Id filtrado.")]
        public async Task<IActionResult> GetById(int id)
        {
            var processoSeletivo = await _service.GetById(id);

            return Ok(processoSeletivo);
        }

        [HttpPost]
        [EndpointSummary("Permite o cadastro de um processo seletivo.")]
        public async Task<IActionResult> Create([FromBody] ProcessoSeletivoDTO processoSeletivo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Add(processoSeletivo);

            return CreatedAtAction(nameof(GetById), new { id = processoSeletivo.Id }, processoSeletivo);
        }

        [HttpPut]
        [EndpointSummary("Permite a edição de dados de um processo seletivo existente.")]
        public async Task<IActionResult> Update(int id, [FromBody] ProcessoSeletivoDTO processoSeletivo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Update(processoSeletivo);

            return Ok(processoSeletivo);
        }

        [HttpDelete("{id}")]
        [EndpointSummary("Permite a deleção de um processo seletivo filtrado pelo Id.")]
        public async Task<IActionResult> Delete(int id)
        {
            var processoSeletivo = await _service.GetById(id);

            await _service.Delete(id);

            return Ok(processoSeletivo);
        }
    }
}

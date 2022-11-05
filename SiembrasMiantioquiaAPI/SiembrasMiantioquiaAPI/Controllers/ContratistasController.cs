using SiembrasMiantioquiaAPI.Models;
using SiembrasMiantioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;


namespace SiembrasMiantioquiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratistasController : ControllerBase
    {
        private readonly ContratistasService _contratistaService;

        public ContratistasController(ContratistasService contratistaService)
        {
            _contratistaService = contratistaService;
        }

        [HttpGet]
        public async Task<List<Contratista>> Get()
        { 
            var losContratista = await _contratistaService.GetAsync();
            return losContratista;
        }
            

        [HttpGet("{codigo:int}")]
        public async Task<ActionResult<Contratista>> Get(int codigo)
        {
            var unContratista = await _contratistaService.GetAsync(codigo);

            if (unContratista is null)
                return NotFound();

            return unContratista;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Contratista contratistaNuevo)
        {
            await _contratistaService.CreateAsync(contratistaNuevo);
            return CreatedAtAction(nameof(Get), new { id = contratistaNuevo.Id }, contratistaNuevo);
        }

        [HttpPut("{codigo:int}")]
        public async Task<IActionResult> Update(int codigo, Contratista contratistaActualizado)
        {
            var unArbol = await _contratistaService.GetAsync(codigo);

            if (unArbol is null)
                return NotFound();

            contratistaActualizado.Id = unArbol.Id;
            await _contratistaService.UpdateAsync(codigo, contratistaActualizado);
            return NoContent();
        }

        [HttpDelete("{codigo:int}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            var contratista = await _contratistaService.GetAsync(codigo);
            if (contratista is null)
                return NotFound();

            await _contratistaService.RemoveAsync(codigo);
            return NoContent();
        }
    }
}
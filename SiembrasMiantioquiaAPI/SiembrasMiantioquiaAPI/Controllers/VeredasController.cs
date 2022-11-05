using SiembrasMiantioquiaAPI.Models;
using SiembrasMiantioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;


namespace SiembrasMiantioquiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeredasController : ControllerBase
    {
        private readonly VeredasService _veredasService;

        public VeredasController(VeredasService veredasService)
        {
            _veredasService = veredasService;
        }

        [HttpGet]
        public async Task<List<Vereda>> Get()
        { 
            var lasVeredas = await _veredasService.GetAsync();
            return lasVeredas;
        }
            

        [HttpGet("{codigo:int}")]
        public async Task<ActionResult<Vereda>> Get(int codigo)
        {
            var unaVereda = await _veredasService.GetAsync(codigo);

            if (unaVereda is null)
                return NotFound();

            return unaVereda;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Vereda veredaNueva)
        {
            await _veredasService.CreateAsync(veredaNueva);
            return CreatedAtAction(nameof(Get), new { id = veredaNueva.Id }, veredaNueva);
        }

        [HttpPut("{codigo:int}")]
        public async Task<IActionResult> Update(int codigo, Vereda veredaActualizada)
        {
            var unaVereda = await _veredasService.GetAsync(codigo);

            if (unaVereda is null)
                return NotFound();

            veredaActualizada.Id = unaVereda.Id;
            await _veredasService.UpdateAsync(codigo, veredaActualizada);
            return NoContent();
        }

        [HttpDelete("{codigo:int}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            var unaVereda = await _veredasService.GetAsync(codigo);
            if (unaVereda is null)
                return NotFound();

            await _veredasService.RemoveAsync(codigo);
            return NoContent();
        }
    }
}
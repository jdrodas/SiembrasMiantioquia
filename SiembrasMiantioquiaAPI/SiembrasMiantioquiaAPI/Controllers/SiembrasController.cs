using SiembrasMiantioquiaAPI.Models;
using SiembrasMiantioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace SiembrasMiantioquiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiembrasController : ControllerBase
    {
        private readonly SiembrasService _siembrasService;

        public SiembrasController(SiembrasService siembrasService)
        {
            _siembrasService = siembrasService;
        }
            

        [HttpGet]
        public async Task<List<Siembra>> Get()
        {
            var lasSiembras = await _siembrasService.GetAsync();
            return lasSiembras;
        }

        [HttpGet("{codigo:int}")]
        public async Task<ActionResult<Siembra>> Get(int codigo)
        {
            var unaSiembra = await _siembrasService.GetAsync(codigo);

            if (unaSiembra is null)
                return NotFound();

            return unaSiembra;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Siembra siembraNueva)
        {
            await _siembrasService.CreateAsync(siembraNueva);
            return CreatedAtAction(nameof(Get), new { id = siembraNueva.Id }, siembraNueva);
        }

        [HttpPut("{codigo:int}")]
        public async Task<IActionResult> Update(int codigo, Siembra siembraActualizada)
        {
            var unaSiembra = await _siembrasService.GetAsync(codigo);

            if (unaSiembra is null)
                return NotFound();

            siembraActualizada.Id = unaSiembra.Id;
            await _siembrasService.UpdateAsync(codigo, siembraActualizada);
            return NoContent();
        }

        [HttpDelete("{codigo:int}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            var unaSiembra = await _siembrasService.GetAsync(codigo);
            if (unaSiembra is null)
                return NotFound();

            await _siembrasService.RemoveAsync(codigo);
            return NoContent();
        }
    }
}
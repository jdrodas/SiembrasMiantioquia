using SiembrasMiantioquiaAPI.Models;
using SiembrasMiantioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;


namespace SiembrasMiantioquiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipiosController : ControllerBase
    {
        private readonly MunicipiosService _municipiosService;

        public MunicipiosController(MunicipiosService municipiosService)
        {
            _municipiosService = municipiosService;
        }

        [HttpGet]
        public async Task<List<Municipio>> Get()
        { 
            var losMunicipios = await _municipiosService.GetAsync();
            return losMunicipios;
        }
            

        [HttpGet("{codigo:int}")]
        public async Task<ActionResult<Municipio>> Get(int codigo)
        {
            var unMunicipio = await _municipiosService.GetAsync(codigo);

            if (unMunicipio is null)
                return NotFound();

            return unMunicipio;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Municipio municipioNuevo)
        {
            await _municipiosService.CreateAsync(municipioNuevo);
            return CreatedAtAction(nameof(Get), new { id = municipioNuevo.Id }, municipioNuevo);
        }

        [HttpPut("{codigo:int}")]
        public async Task<IActionResult> Update(int codigo, Municipio municipioActualizado)
        {
            var unMunicipio = await _municipiosService.GetAsync(codigo);

            if (unMunicipio is null)
                return NotFound();

            municipioActualizado.Id = unMunicipio.Id;
            await _municipiosService.UpdateAsync(codigo, municipioActualizado);
            return NoContent();
        }

        [HttpDelete("{codigo:int}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            var unMunicipio = await _municipiosService.GetAsync(codigo);
            if (unMunicipio is null)
                return NotFound();

            await _municipiosService.RemoveAsync(codigo);
            return NoContent();
        }
    }
}
using SiembrasMiantioquiaAPI.Models;
using SiembrasMiantioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;


namespace SiembrasMiantioquiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArbolesController : ControllerBase
    {
        private readonly ArbolesService _arbolesService;

        public ArbolesController(ArbolesService arbolesService)
        {
            _arbolesService = arbolesService;
        }

        [HttpGet]
        public async Task<List<Arbol>> Get()
        { 
            var losArboles = await _arbolesService.GetAsync();
            return losArboles;
        }
            

        [HttpGet("{codigo:int}")]
        public async Task<ActionResult<Arbol>> Get(int codigo)
        {
            var unArbol = await _arbolesService.GetAsync(codigo);

            if (unArbol is null)
                return NotFound();

            return unArbol;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Arbol arbolNuevo)
        {
            await _arbolesService.CreateAsync(arbolNuevo);
            return CreatedAtAction(nameof(Get), new { id = arbolNuevo.Id }, arbolNuevo);
        }

        [HttpPut("{codigo:int}")]
        [HttpPatch("{codigo:int}")]
        public async Task<IActionResult> Update(int codigo, Arbol arbolActualizado)
        {
            var unArbol = await _arbolesService.GetAsync(codigo);

            if (unArbol is null)
                return NotFound();

            arbolActualizado.Id = unArbol.Id;
            await _arbolesService.UpdateAsync(codigo, arbolActualizado);
            return NoContent();
        }

        [HttpDelete("{codigo:int}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            var arbol = await _arbolesService.GetAsync(codigo);
            if (arbol is null)
                return NotFound();

            await _arbolesService.RemoveAsync(codigo);
            return NoContent();
        }
    }
}
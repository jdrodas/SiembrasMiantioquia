using SiembrasMiantioquiaAPI.Models;
using SiembrasMiantioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiembrasMiantioquiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiembrasController : ControllerBase
    {
        private readonly SiembrasService _siembrasService;

        public SiembrasController(SiembrasService siembrasService) =>
            _siembrasService = siembrasService;

        [HttpGet]
        public async Task<List<Siembra>> Get() =>
            await _siembrasService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Siembra>> Get(string id)
        {
            var siembra = await _siembrasService.GetAsync(id);

            if (siembra is null)
            {
                return NotFound();
            }

            return siembra;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Siembra newSiembra)
        {
            await _siembrasService.CreateAsync(newSiembra);

            return CreatedAtAction(nameof(Get), new { id = newSiembra.Id }, newSiembra);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Siembra updatedSiembra)
        {
            var siembra = await _siembrasService.GetAsync(id);

            if (siembra is null)
            {
                return NotFound();
            }

            updatedSiembra.Id = siembra.Id;

            await _siembrasService.UpdateAsync(id, updatedSiembra);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var siembra = await _siembrasService.GetAsync(id);

            if (siembra is null)
            {
                return NotFound();
            }

            await _siembrasService.RemoveAsync(id);

            return NoContent();
        }
    }
}
using Acreditadora.API.Data;
using Acreditadora.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Acreditadora.API.Controllers
{

    //directivas
    [ApiController]
    [Route("/api/universities")]
    public class UniversitiesController : ControllerBase
    {
        private readonly DataContext dataContext;

        public UniversitiesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Universities.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var university = await dataContext.Universities.FirstOrDefaultAsync(x => x.Id == id);
            if (university == null)
            {
                return NotFound();
            }
            return Ok(university);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(University university)
        {
            dataContext.Universities.Add(university);
            await dataContext.SaveChangesAsync();
            return Ok(university);
        }

        [HttpPut]
        public async Task<ActionResult> Put(University university)
        {
            dataContext.Universities.Update(university);
            await dataContext.SaveChangesAsync();
            return Ok(university);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var affectedRows = await dataContext.Universities.Where(x => x.Id == id)
                .ExecuteDeleteAsync();
            if (affectedRows == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

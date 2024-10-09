using Acreditadora.API.Data;
using Acreditadora.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Acreditadora.API.Controllers
{
    [ApiController]
    [Route("/api/subject")]
    public class SubjectsController : ControllerBase
    {
        private readonly DataContext dataContext;

        public SubjectsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Subjects.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var subject = await dataContext.Subjects.FirstOrDefaultAsync(x => x.Id == id);
            if (subject == null)
            {
                return NotFound();
            }
            return Ok(subject);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Subject subject)
        {
            dataContext.Subjects.Add(subject);
            await dataContext.SaveChangesAsync();
            return Ok(subject);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Subject subject)
        {
            dataContext.Subjects.Update(subject);
            await dataContext.SaveChangesAsync();
            return Ok(subject);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var affectedRows = await dataContext.Subjects.Where(x => x.Id == id)
                .ExecuteDeleteAsync();
            if (affectedRows == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

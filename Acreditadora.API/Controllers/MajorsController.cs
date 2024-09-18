using Acreditadora.API.Data;
using Acreditadora.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acreditadora.API.Controllers
{
    [ApiController]
    [Route("/api/majors")]
    public class MajorsController: ControllerBase
    {
        private readonly DataContext dataContext;

        public MajorsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Major major) //http results
        {
            dataContext.Majors.Add(major); //se agrega
            await dataContext.SaveChangesAsync(); //salva los changos
            return Ok(major);
        }
    }
}
//http request

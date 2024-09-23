using Acreditadora.API.Data;
using Acreditadora.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acreditadora.API.Controllers
{
    [ApiController]
    [Route("/api/students")]
     public class StudentsController : ControllerBase
     {
        private readonly DataContext dataContext;

        public StudentsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Student student) //http results
        {
            dataContext.Students.Add(student); //se agrega
            await dataContext.SaveChangesAsync(); //salva los changos
            return Ok(student);
        }
     }
}


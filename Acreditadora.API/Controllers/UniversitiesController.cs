using Acreditadora.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Acreditadora.API.Controllers
{

    //directivas
    [ApiController]
    [Route("/api/universities")]
    public class UniversitiesController:ControllerBase
    {
        private readonly DataContext dataContext;

        public UniversitiesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}

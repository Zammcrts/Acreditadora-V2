﻿using Acreditadora.API.Data;
using Acreditadora.Shared.Entities;
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
        [HttpPost]
        public async Task<IActionResult> PostAsync(University university) //http results
        {
            dataContext.Universities.Add(university); //se agrega
            await dataContext.SaveChangesAsync(); //salva los changos
            return Ok(university);
        }
    }
}

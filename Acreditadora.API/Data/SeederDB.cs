//mapeo de seeder universities y subjects

using Acreditadora.Shared.Entities;

namespace Acreditadora.API.Data
{
    public class SeederDB
    {
        private readonly DataContext dataContext;

        public SeederDB(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task SeedAsync()
        {
            await dataContext.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCitiesAsync();
            await CheckSubjectsAsync();
            await CheckUnivertsitiesAsync();

        }

        private async Task CheckUnivertsitiesAsync()
        {
            if (!dataContext.Universities.Any())
            {
                dataContext.Universities.Add(new University { Name = "Universidad Iberoamericana", Url = "iberoamerica.mx", PhoneNumber = "1234567890", Address = "Puebla", Active = true });
                dataContext.Universities.Add(new University { Name = "UPAEP", Url = "upaep.mx", PhoneNumber = "2224445551", Address = "Puebla", Active = true });
                dataContext.Universities.Add(new University { Name = "Tecnológico de Monterrey", Url = "tec.monterrey.mx", PhoneNumber = "4445556663", Address = "CDMX", Active = true });

                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckSubjectsAsync()
        {
            if(!dataContext.Subjects.Any())
            {
                dataContext.Subjects.Add(new Subject { Name = "Programación", Credits = 8, Description = "Materia de ingenieria en sistemas", Hours = 4 });
                dataContext.Subjects.Add(new Subject { Name = "Sistemas de información", Credits = 6, Description = "Materia de ingenieria en sistemas", Hours = 4 });
                dataContext.Subjects.Add(new Subject { Name = "Álgebra", Credits = 8, Description = "Tronco común ingenierias", Hours = 4 });

                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckCitiesAsync()
        {
            if(!dataContext.Cities.Any())
            {
                var country = dataContext.Countries.FirstOrDefault(x => x.Name =="Mexico");
                if (country != null)
                {
                    dataContext.Cities.Add(new City { Name = "Puebla", Country = country });
                    dataContext.Cities.Add(new City { Name = "Jalisco", Country = country });
                }
                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckCountriesAsync()
        {
            if(!dataContext.Countries.Any())
            {
                dataContext.Countries.Add(new Country { Name = "Mexico" });
                dataContext.Countries.Add(new Country { Name = "Canada" });
                dataContext.Countries.Add(new Country { Name = "Jamaica" });
                dataContext.Countries.Add(new Country { Name = "Brasil" });

                await dataContext.SaveChangesAsync();
            }
        }

 
    }
}

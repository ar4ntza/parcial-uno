using Microsoft.AspNetCore.Mvc;
using parcial_uno.API.Data;

namespace parcial_uno.API.Controllers
{
    [ApiController]
    [Route("/api/machines")]
    public class MachinesControllers:ControllerBase
    {
        private readonly DataContext dataContext;

        public MachinesControllers(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}

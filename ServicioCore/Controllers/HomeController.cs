using Microsoft.AspNetCore.Mvc;
using ServicioCore;
using ServicioData;

namespace ServicioCore.Controllers
{
    public class HomeController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class HomeController : ControllerBase
        {
            private readonly DataContext _dataContext;

            public HomeController(DataContext dataConext)
            { _dataContext = dataConext; }

            [HttpGet("{Nombre]")]
            public ActionResult Saludo(string Nombre)
            {
                return Ok("Saludos " + ", este es un Servicio .netCore");
            }

            [HttpPost("SelectNotas")]
            public ActionResult SumaDosNumeros()
            {
                return Ok();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Wilson.Api.Controllers
{
    public class TesteController : Controller
    {
        [HttpGet("teste")]
        public IActionResult Teste()
        {
            return Ok("Api running...");
        }
    }
}
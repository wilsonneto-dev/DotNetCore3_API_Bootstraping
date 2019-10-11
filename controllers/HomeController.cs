using Microsoft.AspNetCore.Mvc;

namespace Wilson.Api.Controllers 
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return Ok("ok...");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RunGroupWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

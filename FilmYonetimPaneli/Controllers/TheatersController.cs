using FilmYonetim.Application.Repos;
using Microsoft.AspNetCore.Mvc;

namespace FilmYonetimPaneli.Controllers
{
    public class TheatersController : Controller
    {
        private readonly ITheatersWriteRepos _theatersWriteRepos;
        private readonly ITheatersReadRepos _theatersReadRepos;
        public TheatersController(ITheatersReadRepos theatersReadRepos, ITheatersWriteRepos theatersWriteRepos)
        {
            _theatersReadRepos = theatersReadRepos;
            _theatersWriteRepos = theatersWriteRepos;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _theatersReadRepos.GetAll();
            return Ok(response);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

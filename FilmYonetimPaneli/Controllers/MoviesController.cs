using FilmYonetim.Application.Repos;
using FilmYonetim.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FilmYonetimPaneli.Controllers
{
    [Route("FilmYonetimPaneli/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMoviesWriteRepos _moviesWriteRepos;
        readonly private IMoviesReadRepos _moviesReadRepos;

        public MoviesController(IMoviesWriteRepos moviesWriteRepos, IMoviesReadRepos moviesReadRepos)
        {
            _moviesWriteRepos = moviesWriteRepos;
            _moviesReadRepos = moviesReadRepos;
        }
        [HttpGet]
        public async Task<OkObjectResult> Get()
        {
            return Ok(_moviesReadRepos.GetAll());
        }
        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            Movies movies = await _moviesReadRepos.GetByIdAsync(id);
            return Ok(movies);
        }
        [HttpGet]
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

using FilmYonetim.Application.Abstractions;
using FilmYonetim.Persistance.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmYonetim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet]
        public IActionResult getMovies()
        {
            var movies = _movieService.GetMovies();
            return Ok(movies);
        }
    }
}

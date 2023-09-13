using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly List<Movie> _movies = new List<Movie>
    {
        new Movie { Id = 1, Title = "Movie 1", Genre = "Action", Year = 2020 },
        new Movie { Id = 2, Title = "Movie 2", Genre = "Comedy", Year = 2021 },
        // Add more movies here
    };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return Ok(_movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            if (movie == null)
            {
                return BadRequest("Invalid movie data.");
            }

            movie.Id = _movies.Max(m => m.Id) + 1; // Generate a new ID
            _movies.Add(movie);

            return CreatedAtAction(nameof(Get), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie updatedMovie)
        {
            if (updatedMovie == null || id != updatedMovie.Id)
            {
                return BadRequest("Invalid movie data.");
            }

            var existingMovie = _movies.FirstOrDefault(m => m.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }

            existingMovie.Title = updatedMovie.Title;
            existingMovie.Genre = updatedMovie.Genre;
            existingMovie.Year = updatedMovie.Year;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            _movies.Remove(movie);

            return NoContent();
        }
    }
}

using CinemaReservation.Application.DTOs;
using CinemaReservation.Application.Movies;
using Microsoft.AspNetCore.Mvc;

namespace CinemaReservation.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly GetMovies _getMovies;
    private readonly CreateMovie _createMovie;
    private readonly GetMovieById _getMovieById;
    private readonly DeleteMovieById _deleteMovieById;

    public MoviesController(GetMovies getMovies, CreateMovie createMovie, GetMovieById getMovieById, DeleteMovieById deleteMovieById)
    {
        _getMovies = getMovies;
        _createMovie = createMovie;
        _getMovieById = getMovieById;
        _deleteMovieById = deleteMovieById;
    }

    [HttpGet]
    public async Task<IActionResult> GetMovies()
    {
        var movieList = await _getMovies.ExecuteAsync();

        return Ok(movieList);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMovieById(Guid id)
    {
        var movie = await _getMovieById.ExecuteAsync(id);

        if (movie is null)
        {
            return NotFound();
        }

        return Ok(movie);
    }

    [HttpPost]
    public async Task<IActionResult> CreateMovie(CreateMovieDto createMovieDto)
    {
        var movie = await _createMovie.ExecuteAsync(createMovieDto);

        var actionName = nameof(GetMovieById);

        return CreatedAtAction(actionName, new { id = movie.Id }, movie);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(Guid id)
    {
        bool deleted = await _deleteMovieById.ExecuteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}
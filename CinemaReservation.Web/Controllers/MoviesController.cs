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

    public MoviesController(GetMovies getMovies, CreateMovie createMovie)
    {
        _getMovies = getMovies;
        _createMovie = createMovie;
    }

    [HttpGet]
    public async Task<IActionResult> GetMovies()
    {
        var movieList = await _getMovies.ExecuteAsync();

        return Ok(movieList);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetMovie(int Id)
    {

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateMovie(CreateMovieDto createMovieDto)
    {
        await _createMovie.ExecuteAsync(createMovieDto);

        var actionName = typeof (CreateMovie).Name;

        return CreatedAtAction(actionName, createMovieDto);
    }
}
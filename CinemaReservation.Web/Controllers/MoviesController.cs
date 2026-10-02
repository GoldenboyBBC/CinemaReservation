using CinemaReservation.Application.Movies;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly GetMovies _getMovies;

    public MoviesController(GetMovies getMovies)
    {
        _getMovies = getMovies;
    }

    [HttpGet]
    public async Task<IActionResult> GetMovies()
    {
        var movieList = await _getMovies.ExecuteAsync();

        return Ok(movieList);
    }
}
using CinemaReservation.Application.DTOs;
using CinemaReservation.Application.Interfaces;

namespace CinemaReservation.Application.Movies;

public class GetMovieById
{
    private readonly IMovieRepository _movieRepository;

    public GetMovieById(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<MovieDto?> ExecuteAsync(Guid id)
    {
        var movie = await _movieRepository.GetMovieByIdAsync(id);

        if (movie is null)
        {
            return null;
        }

        var movieDto = new MovieDto()
        {
            Id = movie.Id,
            Name = movie.Name,
            Description = movie.Description,
            Duration = movie.Duration,
            Creator = movie.Creator,
            ReleaseDate = movie.ReleaseDate,
        };

        return movieDto;
    }
}

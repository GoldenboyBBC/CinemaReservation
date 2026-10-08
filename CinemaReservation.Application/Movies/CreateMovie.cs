using CinemaReservation.Application.Interfaces;
using CinemaReservation.Application.DTOs;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Application.Movies;

public class CreateMovie
{
    private readonly IMovieRepository _movieRepository;

    public CreateMovie(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<MovieDto> ExecuteAsync(CreateMovieDto createMovieDto)
    {
        var movie = new Movie()
        {
            Id = Guid.NewGuid(),
            Name = createMovieDto.Name,
            Description = createMovieDto.Description,
            Duration = createMovieDto.Duration,
            Creator = createMovieDto.Creator,
            ReleaseDate = createMovieDto.ReleaseDate,
        };

        await _movieRepository.AddMovieAsync(movie);

        return new MovieDto()
        {
            Id = movie.Id,
            Name = movie.Name,
            Description = movie.Description,
            Duration = movie.Duration,
            Creator = movie.Creator,
            ReleaseDate = movie.ReleaseDate,
        };
    }
}

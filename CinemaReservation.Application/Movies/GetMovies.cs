using CinemaReservation.Application.Interfaces;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Application.Movies;

public class GetMovies
{
    private readonly IMovieRepository _movieRepository;

    public GetMovies(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<IReadOnlyList<Movie>> ExecuteAsync()
    {
        return await _movieRepository.GetMoviesAsync();
    }
}
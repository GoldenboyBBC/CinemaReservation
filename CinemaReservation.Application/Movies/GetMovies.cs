using CinemaReservation.Application.Interfaces;
using CinemaReservation.Application.DTOs;

namespace CinemaReservation.Application.Movies;

public class GetMovies
{
    private readonly IMovieRepository _movieRepository;

    public GetMovies(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<IReadOnlyList<MovieDto>> ExecuteAsync()
    {
        var movies = await _movieRepository.GetMoviesAsync();

        var movieList = new List<MovieDto>();

        foreach (var movie in movies)
        {
            movieList.Add (
                    new MovieDto()
                    {
                        Id = movie.Id,
                        Name = movie.Name,
                        Description = movie.Description,
                        Duration = movie.Duration,
                        Creator = movie.Creator,
                        ReleaseDate = movie.ReleaseDate,
                    }
                );
        }

        return movieList;
    }
}
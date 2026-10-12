using CinemaReservation.Application.Interfaces;
using CinemaReservation.Application.DTOs;
using AutoMapper;

namespace CinemaReservation.Application.Movies;

public class GetMovies
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public GetMovies(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<MovieDto>> ExecuteAsync()
    {
        var movies = await _movieRepository.GetMoviesAsync();

        var movieList = new List<MovieDto>();

        foreach (var movie in movies)
        {
            movieList.Add(_mapper.Map<MovieDto>(movie));
        }

        return movieList;
    }
}
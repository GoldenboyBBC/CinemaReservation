using CinemaReservation.Application.DTOs;
using CinemaReservation.Application.Interfaces;
using AutoMapper;

namespace CinemaReservation.Application.Movies;

public class GetMovieById
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public GetMovieById(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public async Task<MovieDto?> ExecuteAsync(Guid id)
    {
        var movie = await _movieRepository.GetMovieByIdAsync(id);

        if (movie is null)
        {
            return null;
        }

        return _mapper.Map<MovieDto>(movie);
    }
}

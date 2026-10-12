using CinemaReservation.Application.Interfaces;
using CinemaReservation.Application.DTOs;
using CinemaReservation.Domain.Entities;
using AutoMapper;

namespace CinemaReservation.Application.Movies;

public class CreateMovie
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public CreateMovie(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public async Task<MovieDto> ExecuteAsync(CreateMovieDto createMovieDto)
    {
        var movie = _mapper.Map<Movie>(createMovieDto);
        movie.Id = Guid.NewGuid();

        await _movieRepository.AddMovieAsync(movie);

        return _mapper.Map<MovieDto>(movie);
    }
}

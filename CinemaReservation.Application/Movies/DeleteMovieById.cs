using CinemaReservation.Application.DTOs;
using CinemaReservation.Application.Interfaces;
using AutoMapper;

namespace CinemaReservation.Application.Movies;

public class DeleteMovieById
{
    private readonly IMovieRepository _movieRepository;

    public DeleteMovieById(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<bool> ExecuteAsync(Guid id)
    {
        return await _movieRepository.DeleteMovieById(id);
    }
}
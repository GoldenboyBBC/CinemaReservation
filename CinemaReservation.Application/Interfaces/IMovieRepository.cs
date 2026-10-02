using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Application.Interfaces;

public interface IMovieRepository
{
    Task<IReadOnlyList<Movie>> GetMoviesAsync();
}
using CinemaReservation.Application.Interfaces;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    public async Task<IReadOnlyList<Movie>> GetMoviesAsync()
    {
        IReadOnlyList<Movie> movies = new List<Movie>()
        {
            new Movie()
            {
                Id = Guid.NewGuid(),
                Name = "Bruh Brothers",
                Creator = "Amir",
                Description = "Cool Movie",
                Duration = DateTime.Now - DateTime.Now.AddHours(1).AddMinutes(30),
                ReleaseDate = DateTime.Now.AddYears(-20)
            },

            new Movie()
            {
                Id = Guid.NewGuid(),
                Name = "Trust Me",
                Creator = "Mohammad",
                Description = "Trash Movie",
                Duration = DateTime.Now - DateTime.Now.AddHours(2).AddMinutes(15),
                ReleaseDate = DateTime.Now.AddYears(-5)
            },

        };

        return movies;
    }
}
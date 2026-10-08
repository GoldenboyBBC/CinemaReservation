using CinemaReservation.Application.Interfaces;
using CinemaReservation.Domain.Entities;
using CinemaReservation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CinemaReservation.Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly CinemaDbContext _context;

    public MovieRepository(CinemaDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Movie>> GetMoviesAsync()
    {
        return await _context.Movies.ToListAsync();
    }

    public async Task AddMovieAsync(Movie movie)
    {
        _context.Movies.Add(movie);

        await _context.SaveChangesAsync();
    }
}
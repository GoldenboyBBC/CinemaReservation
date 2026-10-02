using Microsoft.EntityFrameworkCore;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Infrastructure.Data;

public class CinemaDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
    {

    }
}
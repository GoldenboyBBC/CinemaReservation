using CinemaReservation.Infrastructure.Data;
using CinemaReservation.Application.Interfaces;
using CinemaReservation.Infrastructure.Repositories;
using CinemaReservation.Application.Movies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddControllers();

builder.Services.AddDbContext<CinemaDbContext> (
    options => options.UseNpgsql (
            builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<GetMovies>();
builder.Services.AddScoped<CreateMovie>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
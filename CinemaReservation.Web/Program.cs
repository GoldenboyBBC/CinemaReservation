using CinemaReservation.Infrastructure.Data;
using CinemaReservation.Application.Interfaces;
using CinemaReservation.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<CinemaDbContext> (
    options => options.UseNpgsql (
            builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<IMovieRepository, MovieRepository>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
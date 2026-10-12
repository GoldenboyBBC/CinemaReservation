using AutoMapper;
using CinemaReservation.Application.DTOs;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Application.Mapping;

public class MovieMappingProfile : Profile
{
    public MovieMappingProfile()
    {
        CreateMap<Movie, MovieDto>();
        CreateMap<CreateMovieDto, Movie>();
    }
}
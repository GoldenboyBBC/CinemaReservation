namespace CinemaReservation.Application.DTOs;

public class CreateMovieDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public string Creator { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
}

namespace CinemaReservation.Domain.Entities;

public class Movie
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public string Creator { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
}
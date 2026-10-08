using CinemaReservation.Application.DTOs;
using FluentValidation;

namespace CinemaReservation.Application.Validators;

public class CreateMovieValidator : AbstractValidator<CreateMovieDto>
{
    public CreateMovieValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Duration)
            .GreaterThan(TimeSpan.Zero)
            .LessThanOrEqualTo(TimeSpan.FromHours(10));

        RuleFor(x => x.Description)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.Creator)
            .NotEmpty()
            .MaximumLength(50);
    }
}
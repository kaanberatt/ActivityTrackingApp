using ActivityTrackingApp.Entities.Concrete;
using FluentValidation;

namespace ActivityTrackingApp.Entities.EntityValidator;

public class UserActivitiesValidator : AbstractValidator<UserActivities>
{
    public UserActivitiesValidator()
    {
        RuleFor(x => x.StartDate)
            .NotEmpty().WithMessage("Start date alanı boş olamaz");

        RuleFor(x => x.AppUserId)
            .NotEmpty().WithMessage("AppUser Id değeri boş olamaz.");

        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("Event Id değeri boş olamaz.");
    }
}

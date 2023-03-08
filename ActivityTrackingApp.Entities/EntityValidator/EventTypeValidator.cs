using ActivityTrackingApp.Entities.Concrete;
using FluentValidation;

namespace ActivityTrackingApp.Entities.EntityValidator;

public class EventTypeValidator : AbstractValidator<EventType>
{
	public EventTypeValidator()
	{
		RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("EventType Name değeri null olamaz.");
		RuleFor(x => x.Name).Length(3,80).WithMessage("EventType Name değeri 3 ve 80 karakter arasında olmalıdır.");
	}
}

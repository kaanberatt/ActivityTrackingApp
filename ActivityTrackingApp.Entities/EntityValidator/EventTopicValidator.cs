using ActivityTrackingApp.Entities.Concrete;
using FluentValidation;

namespace ActivityTrackingApp.Entities.EntityValidator;

public class EventTopicValidator : AbstractValidator<EventTopic>
{
	public EventTopicValidator()
	{

		RuleFor(x => x.Name)
			.NotNull().NotEmpty().WithMessage("Event Topic Name değeri null olamaz.")
			.Length(3,80).WithMessage("Event Topic Name değeri 3 ve 80 karakter arasında olmalıdır.");
	}
}

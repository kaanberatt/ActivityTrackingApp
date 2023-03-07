﻿using ActivityTrackingApp.Entities.Concrete;
using FluentValidation;

namespace ActivityTrackingApp.Entities.EntityValidator;

public class EventValidator : AbstractValidator<Event>
{
	public EventValidator()
	{
		RuleFor(x => x.Id).NotNull().NotEmpty().WithMessage("Event Id değeri null olamaz.");
		RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Event Name değeri null olamaz.");
		RuleFor(x => x.Name).Length(3,80).WithMessage("Event Name değeri 3 ve 80 karakter arasında olmalıdır.");
	}
}
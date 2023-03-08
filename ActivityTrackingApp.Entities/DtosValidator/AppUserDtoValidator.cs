using ActivityTrackingApp.Entities.Dtos;
using FluentValidation;

namespace ActivityTrackingApp.Entities.DtosValidator;
public class AppUserDtoValidator : AbstractValidator<AppUserDto>
{
	public AppUserDtoValidator()
	{
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("İsim boş olamaz.")
            .Length(2, 50).WithMessage("İsim 2-50 karakter arasında olmalıdır.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Soyisim boş olamaz.")
            .Length(2, 50).WithMessage("Soyisim 2-50 karakter arasında olmalıdır.");

        RuleFor(x => x.Tc)
            .NotEmpty().WithMessage("TC Kimlik Numarası boş olamaz.")
            .Matches(@"^\d{11}$").WithMessage("TC Kimlik Numarası 11 rakam içermelidir.");

        RuleFor(x => x.Age)
            .InclusiveBetween(0, 100).WithMessage("Yaş 0-100 arasında olmalıdır.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("E-posta boş olamaz.")
            .EmailAddress().WithMessage("Geçersiz e-posta adresi.");

        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Telefon numarası boş olamaz.")
            .Matches(@"^([0-9\(\)\/\+ \-]*)$").WithMessage("Geçersiz telefon numarası formatı.");

        RuleFor(x => x.City)
            .NotEmpty().WithMessage("Şehir boş olamaz.")
            .Length(2, 50).WithMessage("Şehir 2-50 karakter arasında olmalıdır.");

        RuleFor(x => x.Education)
            .NotEmpty().WithMessage("Eğitim boş olamaz.")
            .Length(2, 50).WithMessage("Eğitim 2-50 karakter arasında olmalıdır.");
    }
}

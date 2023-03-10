    using ActivityTrackingApp.Entities.Concrete;
using FluentValidation;

namespace ActivityTrackingApp.Entities.EntityValidator;

public class AppUserValidator : AbstractValidator<AppUser>
{
    public AppUserValidator()
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
            //.Must(BeAValidTCNo).WithMessage("Geçersiz TC Kimlik Numarası.");

        RuleFor(x => x.Age)
            .InclusiveBetween(0, 100).WithMessage("Yaş 0-100 arasında olmalıdır.");

        RuleFor(x => x.Gender).Must(x => x == "Kadın" || x == "Erkek")
                              .WithMessage("Cinsiyet sadece 'Kadın' veya 'Erkek' olabilir.");

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

    public bool BeAValidTCNo(string tcNo)
    {
        if (string.IsNullOrEmpty(tcNo) || tcNo.Length != 11)
            return false;

        int[] digits = tcNo.Select(c => int.Parse(c.ToString())).ToArray();
        int[] firstNineDigits = digits.Take(9).ToArray();

        int totalOddDigits = firstNineDigits.Where((x, i) => i % 2 == 0).Sum();
        int totalEvenDigits = firstNineDigits.Where((x, i) => i % 2 == 1).Sum() * 7;
        int total = (totalOddDigits - totalEvenDigits) % 10;

        if (digits.Take(10).Sum() % 10 != total)
            return false;

        return true;
    }
}

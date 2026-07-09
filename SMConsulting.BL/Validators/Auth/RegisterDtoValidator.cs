using FluentValidation;
using SMConsulting.BL.DTOs.Auth;

namespace SMConsulting.BL.Validators.Auth
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x => x.UserUserName)
           .NotEmpty().WithMessage("İstifadəçi adı boş ola bilməz")
           .MinimumLength(3).WithMessage("İstifadəçi adı minimum 3 simvol olmalıdır")
           .MaximumLength(50).WithMessage("İstifadəçi adı maksimum 50 simvol ola bilər")
           .Matches(@"^[a-zA-Z0-9._]+$").WithMessage("İstifadəçi adı yalnız hərf, rəqəm, nöqtə və alt xətt içərə bilər");

            RuleFor(x => x.UserFullName)
            .NotEmpty().WithMessage("Ad Soyad boş ola bilməz")
            .MinimumLength(5).WithMessage("Ad Soyad minimum 5 simvol olmalıdır")
            .MaximumLength(100).WithMessage("Ad Soyad maksimum 100 simvol ola bilər")
            .Matches(@"^[a-zA-ZəüöğışçƏÜÖĞİŞÇ\s]+$").WithMessage("Ad Soyad yalnız hərf içərə bilər");


            RuleFor(x => x.UserEmail)
          .NotEmpty().WithMessage("Email boş ola bilməz")
          .EmailAddress().WithMessage("Email formatı düzgün deyil");
        


            RuleFor(x => x.UserPassword)
          .NotEmpty().WithMessage("Şifrə boş ola bilməz")
          .MinimumLength(8).WithMessage("Şifrə minimum 8 simvol olmalıdır")
          .MaximumLength(100).WithMessage("Şifrə maksimum 100 simvol ola bilər")
          .Matches(@"[A-Z]").WithMessage("Şifrədə ən az 1 böyük hərf olmalıdır")
          .Matches(@"[a-z]").WithMessage("Şifrədə ən az 1 kiçik hərf olmalıdır")
          .Matches(@"[0-9]").WithMessage("Şifrədə ən az 1 rəqəm olmalıdır")
          .Matches(@"[!@#$%^&*(),.?""':{}|<>]").WithMessage("Şifrədə ən az 1 xüsusi simvol olmalıdır");
        }
    }
}

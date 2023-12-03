using EasyCashEntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentityDtoLayer.Dtos.AppUserDtos;

namespace EasyCashIdentityBusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
                RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Şifreler uyuşmuyor");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim en az 3 karakter olmalıdır");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Soyisim en az 3 karakter olmalıdır");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Şifre en az 5 karakter olmalıdır");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karakter olmalıdır");


        }
    }
}

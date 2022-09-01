using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
   public class TeamValidator:AbstractValidator<Team>
    {
        public TeamValidator()
        {
            //naöe
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsim değeri boş geçilemez");
            RuleFor(x => x.PersonName).MinimumLength(2).WithMessage("İsim değeri en az 2 karakter olabilir");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("İsim değeri en fazla 50 karakter olabilir");
            //surname
            RuleFor(x => x.PersonSurName).NotEmpty().WithMessage("Soyisim değeri boş geçilemez");
            RuleFor(x => x.PersonSurName).MinimumLength(2).WithMessage("Soyisim değeri en az 2 karakter olabilir");
            RuleFor(x => x.PersonSurName).MaximumLength(50).WithMessage("Soyisim değeri en fazla 50 karakter olabilir");
            //title
            RuleFor(x => x.Title).NotEmpty().WithMessage("Unvan değeri boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Unvan değeri en az 2 karakter olabilir");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Unvan değeri en fazla 50 karakter olabilir");
            //ımage
            RuleFor(x => x.ImageUrl).MaximumLength(250).WithMessage("Resim bağlantısı en fazla 250 karakter olabilir");
        }
    }
}

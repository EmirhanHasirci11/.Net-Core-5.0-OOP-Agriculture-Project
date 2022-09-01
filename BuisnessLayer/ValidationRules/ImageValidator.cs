using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class ImageValidator:AbstractValidator<Image>
    {
        public ImageValidator()
        {
            //description
            RuleFor(x => x.Description).NotEmpty().WithMessage("Resim açıklama kısmı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Resim açıklama kısmı en az 20 karakter olabilir");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Resim açıklama kısmı en fazla 50 karakter olabilir");
            //title
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmı boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Başlık kısmı en fazla 20 karakter olabilir");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Başlık kısmı en az 8 karakter olabilir");
            //ımage
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim bağlantısı boş geçilemez");
        }
    }
}

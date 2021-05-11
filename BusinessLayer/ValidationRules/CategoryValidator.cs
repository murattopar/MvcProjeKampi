﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public class CategoryValidator : AbstractValidator<Category>
  {
    public CategoryValidator()
    {
      RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");
      RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz.");
      RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adını en az 3 karakter girmelisiniz.");
      RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori Adını en fazla 50 karakter girebilirsiniz.");
    }
  }
}

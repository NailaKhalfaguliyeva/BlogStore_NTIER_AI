using BlogStore_NTIER_AI_EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore_NTIER_AI_BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Please enter the category name");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Please enter data of at least 3 characters!");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Please enter data of maximum 30 characters!");
        }
    }
}

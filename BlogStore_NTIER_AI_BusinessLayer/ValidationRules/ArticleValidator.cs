using BlogStore_NTIER_AI_EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore_NTIER_AI_BusinessLayer.ValidationRules
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title field cannot be empty")
                          .MinimumLength(10).WithMessage("Please enter at least 10 characters of data.")
                          .MaximumLength(100).WithMessage("Please enter data of maximum 100 characters.");
        }
    }
}




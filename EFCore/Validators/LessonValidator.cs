using EFCore.Domain.Core;
using EFCore.Models;
using FluentValidation;
namespace EFCore.Validators
{
    public class LessonValidator : AbstractValidator<AppLesson>
    {
        public LessonValidator()
        {            
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a name of lesson");   
        }
    }
}
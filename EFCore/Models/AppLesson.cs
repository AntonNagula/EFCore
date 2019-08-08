using EFCore.Validators;
using FluentValidation.Attributes;
namespace EFCore.Models
{
    [Validator(typeof(LessonValidator))]
    public class AppLesson
    {
        public string Name { get; set; }
    }
}
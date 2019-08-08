using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFCore.Domain.Core;
using EFCore.Models;
using FluentValidation;

namespace EFCore.Validators
{
    public class StudentValidator : AbstractValidator<AppStudent>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a first name");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Please specify a second name");
        }
    }
}
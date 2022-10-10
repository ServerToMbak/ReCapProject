using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u=>u.Email).NotEmpty();
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u=>u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(2).MaximumLength(10);
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(2).MaximumLength(15);
            
        }
    }
}

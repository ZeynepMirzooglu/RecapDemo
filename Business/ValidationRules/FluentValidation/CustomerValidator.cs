using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.FirstName).NotEmpty();
            RuleFor(c=>c.LastName).NotEmpty();
            RuleFor(c => c.IdentityNumber).NotEmpty();
        }
    }
}

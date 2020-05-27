using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Author.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {

            RuleFor(e => e.FirstName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(e => e.LastName)
                .NotEmpty()
                .MaximumLength(50);

        }
    }
}

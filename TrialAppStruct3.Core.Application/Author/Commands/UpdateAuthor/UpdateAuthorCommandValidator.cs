using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Author.Commands.UpdateAuthor
{
    class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorCommandValidator()
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

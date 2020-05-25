using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.CreatePublisher
{
    public class CreatePublisherCommandValidator : AbstractValidator<CreatePublisherCommand>
    {
        public CreatePublisherCommandValidator()
        {
            //RuleFor(d => d.PublisherID)
            //    .NotEmpty();

            RuleFor(d => d.PublishingHouse)
                .NotEmpty()
                .MaximumLength(50)
                .WithMessage("Publishing House must be specified");

            RuleFor(d => d.Address)
                .MaximumLength(250);
        }
    }
}

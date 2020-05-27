using FluentValidation;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.UpdatePublisher
{
    public class UpdatePublisherCommandValidator : AbstractValidator<UpdatePublisherCommand>
    {
        public UpdatePublisherCommandValidator()
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
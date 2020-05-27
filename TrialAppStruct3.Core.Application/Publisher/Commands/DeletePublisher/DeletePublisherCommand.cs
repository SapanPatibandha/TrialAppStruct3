using MediatR;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.DeletePublisher
{
    public class DeletePublisherCommand : IRequest
    {
        public int Id { get; set; }
    }
}
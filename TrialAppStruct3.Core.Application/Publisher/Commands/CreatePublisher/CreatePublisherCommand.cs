using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.CreatePublisher
{
    public class CreatePublisherCommand : IRequest
    {
        public int PublisherID { get; set; }

        public string PublishingHouse { get; set; }

        public string Address { get; set; }


        public class Handler : IRequestHandler<CreatePublisherCommand>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMediator _mediator;

            public Handler(IApplicationDbContext context, IMediator mediator)
            {
                this._context = context;
                this._mediator = mediator;
            }

            public async Task<Unit> Handle(CreatePublisherCommand request, CancellationToken cancellationToken)
            {
                var entity = new TrialAppStruct3.Core.Domain.Entities.Publisher
                {
                    PublisherID = request.PublisherID,
                    PublishingHouse = request.PublishingHouse,
                    Address = request.Address
                };

                _context.Publishers.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new PublisherCreated { PublisherID = entity.PublisherID }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Exception;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.UpdatePublisher
{
    public class UpdatePublisherCommand : IRequest
    {
        public int PublisherID { get; set; }

        public string PublishingHouse { get; set; }

        public string Address { get; set; }

        public class Handler : IRequestHandler<UpdatePublisherCommand>
        {
            private readonly IApplicationDbContext _context;

            public Handler(IApplicationDbContext context)
            {
                this._context = context;
            }

            public async Task<Unit> Handle(UpdatePublisherCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Publishers
                    .SingleOrDefaultAsync(c => c.PublisherID == request.PublisherID, cancellationToken);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Publisher), request.PublisherID);
                }

                entity.PublishingHouse = request.PublishingHouse;
                entity.Address = request.Address;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
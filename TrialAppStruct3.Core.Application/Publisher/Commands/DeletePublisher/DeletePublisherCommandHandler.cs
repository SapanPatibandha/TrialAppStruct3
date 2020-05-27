using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Exception;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.DeletePublisher
{
    public class DeletePublisherCommandHandler : IRequestHandler<DeletePublisherCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeletePublisherCommandHandler(IApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Unit> Handle(DeletePublisherCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Publishers
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(TrialAppStruct3.Core.Domain.Entities.Publisher), request.Id);
            }

            var hasBooks = _context.Books.Any(o => o.PublisherID == entity.PublisherID);
            if (hasBooks)
            {
                throw new DeleteFailureException(nameof(TrialAppStruct3.Core.Domain.Entities.Publisher), request.Id, "There are existing books associated with this Publisher.");
            }

            _context.Publishers.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
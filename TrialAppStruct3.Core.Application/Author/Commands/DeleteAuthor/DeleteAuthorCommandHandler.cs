using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Exception;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Core.Application.Author.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAuthorCommandHandler(IApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Unit> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Authors
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(TrialAppStruct3.Core.Domain.Entities.Author), request.Id);
            }

            var hasBooks = _context.Books.Any(o => o.AuthorID == entity.AuthorID);
            if (hasBooks)
            {
                throw new DeleteFailureException(nameof(TrialAppStruct3.Core.Domain.Entities.Author), request.Id, "There are existing books associated with this Author.");
            }

            _context.Authors.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

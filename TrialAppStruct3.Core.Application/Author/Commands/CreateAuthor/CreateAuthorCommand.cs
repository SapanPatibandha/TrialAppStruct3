using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Core.Application.Author.Commands.CreateAuthor
{
    public class CreateAuthorCommand : IRequest
    {
        public int AuthorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }


        public class Handler : IRequestHandler<CreateAuthorCommand>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMediator _mediator;

            public Handler(IApplicationDbContext context, IMediator mediator)
            {
                this._context = context;
                this._mediator = mediator;
            }

            public async Task<Unit> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
            {
                var entity = new TrialAppStruct3.Core.Domain.Entities.Author
                {
                    AuthorID = request.AuthorID,
                    FirstName = request.FirstName,
                    LastName= request.LastName, 
                    DOB = request.DOB
                };

                _context.Authors.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new AuthorCreated { AuthorID = entity.AuthorID }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}

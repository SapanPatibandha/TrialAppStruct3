using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Exception;
using TrialAppStruct3.Core.Application.Common.Interfaces;
using TrialAppStruct3.Core.Domain.Entities;

namespace TrialAppStruct3.Core.Application.Author.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand : IRequest
    {
        public int AuthorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }


        public class Handler : IRequestHandler<UpdateAuthorCommand>
        {
            private readonly IApplicationDbContext _context;

            public Handler(IApplicationDbContext context)
            {
                this._context = context;
            }


            public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Authors
                    .SingleOrDefaultAsync(c => c.AuthorID == request.AuthorID, cancellationToken);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Author), request.AuthorID);
                }

                entity.FirstName = request.FirstName;
                entity.LastName= request.LastName;
                entity.DOB = request.DOB;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}

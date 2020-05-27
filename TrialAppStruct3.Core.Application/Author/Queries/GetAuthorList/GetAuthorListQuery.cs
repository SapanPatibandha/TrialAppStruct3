using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Core.Application.Author.Queries.GetAuthorList
{
    public class GetAuthorListQuery : IRequest<AuthorListVm>
    {
        public class GetAuthorListQueryHandler : IRequestHandler<GetAuthorListQuery, AuthorListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAuthorListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                this._context = context;
                this._mapper = mapper;
            }

            public async Task<AuthorListVm> Handle(GetAuthorListQuery request, CancellationToken cancellationToken)
            {
                var author = await _context.Authors
                    .ProjectTo<AuthorLookupDto>(_mapper.ConfigurationProvider)
                    .OrderBy(e => e.FirstName)
                    .ToListAsync(cancellationToken);

                var vm = new AuthorListVm
                {
                    Authors = author
                };

                return vm;
            }
        }

    }
}

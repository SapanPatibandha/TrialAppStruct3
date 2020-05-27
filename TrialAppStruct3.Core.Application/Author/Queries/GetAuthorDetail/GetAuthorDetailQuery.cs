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

namespace TrialAppStruct3.Core.Application.Author.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQuery : IRequest<AuthorDetailVm>
    {
        public int Id { get; set; }

        public class GetAuthorDetailQueryHandler : IRequestHandler<GetAuthorDetailQuery, AuthorDetailVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetAuthorDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                this._context = context;
                this._mapper = mapper;
            }

            public async Task<AuthorDetailVm> Handle(GetAuthorDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.Authors
                    .Where(e => e.AuthorID == request.Id)
                    .ProjectTo<AuthorDetailVm>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }
    }
}

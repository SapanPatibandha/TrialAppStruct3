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

namespace TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList
{
    public class GetPublisherListQuery : IRequest<PublisherListVm>
    {

        public class GetPublisherListQueryHandler : IRequestHandler<GetPublisherListQuery, PublisherListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetPublisherListQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                this._context = context;
                this._mapper = mapper;
            }

            public async Task<PublisherListVm> Handle(GetPublisherListQuery request, CancellationToken cancellationToken)
            {
                var publisher = await _context.Publishers
                    .ProjectTo<PublisherLookupDto>(_mapper.ConfigurationProvider)
                    .OrderBy(e => e.PublishingHouse)
                    .ToListAsync(cancellationToken);

                var vm = new PublisherListVm
                {
                    Publishers = publisher
                };

                return vm;
            }
        }

    }
}

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherDetail
{
    public class GetPublisherDetailQuery : IRequest<PublisherDetailVm>
    {
        public int Id { get; set; }

        public class GetPublisherDetailQueryHandler : IRequestHandler<GetPublisherDetailQuery, PublisherDetailVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetPublisherDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                this._context = context;
                this._mapper = mapper;
            }

            public async Task<PublisherDetailVm> Handle(GetPublisherDetailQuery request, CancellationToken cancellationToken)
            {
                var vm = await _context.Publishers
                    .Where(e => e.PublisherID == request.Id)
                    .ProjectTo<PublisherDetailVm>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                return vm;
            }
        }
    }
}
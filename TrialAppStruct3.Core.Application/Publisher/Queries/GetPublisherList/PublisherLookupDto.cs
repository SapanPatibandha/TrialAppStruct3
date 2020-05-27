using AutoMapper;
using TrialAppStruct3.Core.Application.Common.Mappings;

namespace TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList
{
    public class PublisherLookupDto : IMapFrom<TrialAppStruct3.Core.Domain.Entities.Publisher>
    {
        public int PublisherID { get; set; }

        public string PublishingHouse { get; set; }

        public string Address { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TrialAppStruct3.Core.Domain.Entities.Publisher, PublisherLookupDto>()
                .ForMember(p => p.PublisherID, pmv => pmv.MapFrom(s => s.PublisherID))
                .ForMember(p => p.PublishingHouse, pmv => pmv.MapFrom(s => s.PublishingHouse))
                .ForMember(p => p.Address, pmv => pmv.MapFrom(s => s.Address));
        }
    }
}
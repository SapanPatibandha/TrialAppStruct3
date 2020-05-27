using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrialAppStruct3.Core.Application.Common.Mappings;

namespace TrialAppStruct3.Core.Application.Author.Queries.GetAuthorDetail
{
    public class AuthorDetailVm : IMapFrom<TrialAppStruct3.Core.Domain.Entities.Author>
    {
        public int AuthorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TrialAppStruct3.Core.Domain.Entities.Author, AuthorDetailVm>()
                .ForMember(p => p.AuthorID, pmv => pmv.MapFrom(s => s.AuthorID))
                .ForMember(p => p.FirstName, pmv => pmv.MapFrom(s => s.FirstName))
                .ForMember(p => p.LastName, pmv => pmv.MapFrom(s => s.LastName))
                .ForMember(p => p.DOB, pmv => pmv.MapFrom(s => s.DOB));
        }


    }
}

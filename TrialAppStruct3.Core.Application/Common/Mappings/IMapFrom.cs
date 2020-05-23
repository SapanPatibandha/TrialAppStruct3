using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Common.Mappings
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}

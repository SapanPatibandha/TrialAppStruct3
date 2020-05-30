using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList;

namespace TrialAppStruct3BlazorApp.Services
{
    public interface IPublisherService
    {
        Task<PublisherListVm> GetAll();
    }
}

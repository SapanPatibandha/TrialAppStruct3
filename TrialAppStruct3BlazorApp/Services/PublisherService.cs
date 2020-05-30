using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList;

namespace TrialAppStruct3BlazorApp.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly HttpClient httpClient;

        public PublisherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PublisherListVm> GetAll()
        {
            return await httpClient.GetJsonAsync<PublisherListVm>("api/v1/publisher/getall");
        }
    }
}

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList;
using TrialAppStruct3BlazorApp.Services;

namespace TrialAppStruct3BlazorApp.Pages.Admin.Master
{
    public partial class PublisherList : ComponentBase
    {
        public PublisherListVm Publishers { get; set; }

        [Inject]
        public IPublisherService PublisherService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Publishers = await PublisherService.GetAll();
        }
    }
}

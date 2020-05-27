using System.Collections.Generic;

namespace TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList
{
    public class PublisherListVm
    {
        public IList<PublisherLookupDto> Publishers { get; set; }
    }
}
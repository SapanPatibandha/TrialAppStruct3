using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList
{
    public class PublisherListVm
    {
        public IList<PublisherLookupDto> Publishers { get; set; }
    }
}

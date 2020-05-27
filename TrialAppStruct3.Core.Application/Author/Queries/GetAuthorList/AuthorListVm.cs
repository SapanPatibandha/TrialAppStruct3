using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Author.Queries.GetAuthorList
{
    public class AuthorListVm
    {
        public IList<AuthorLookupDto> Authors { get; set; }
    }
}

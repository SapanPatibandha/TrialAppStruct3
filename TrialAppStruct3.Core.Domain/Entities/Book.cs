using System;
using System.Collections.Generic;
using System.Text;
using TrialAppStruct3.Core.Domain.Common;

namespace TrialAppStruct3.Core.Domain.Entities
{
    public class Book : AuditEntity
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public int AuthorID { get; set; }

        public int PublisherID { get; set; }


        public Author Author { get; set; }

        public Publisher Publisher { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TrialAppStruct3.Core.Domain.Common;

namespace TrialAppStruct3.Core.Domain.Entities
{
    public class Publisher : AuditEntity
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int PublisherID { get; set; }

        public string PublishingHouse { get; set; }

        public string Address { get; set; }

        public ICollection<Book> Books { get; private set; }
    }
}

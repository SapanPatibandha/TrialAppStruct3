using System;
using System.Collections.Generic;
using TrialAppStruct3.Core.Domain.Common;

namespace TrialAppStruct3.Core.Domain.Entities
{
    public class Author : AuditEntity
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public ICollection<Book> Books { get; private set; }
    }
}
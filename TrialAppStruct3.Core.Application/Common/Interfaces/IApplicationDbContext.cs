using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Domain.Entities;

namespace TrialAppStruct3.Core.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TrialAppStruct3.Core.Domain.Entities.Publisher> Publishers { get; set; }

        DbSet<Author> Authors { get; set; }

        DbSet<Book> Books { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalR_Blazor.Shared;

namespace SignalR_Blazor.Server.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<SignalR_Blazor.Shared.Book> Book { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pinewood.Models;

namespace Pinewood.Data
{
    public class PinewoodDbContext : DbContext
    {
        public PinewoodDbContext (DbContextOptions<PinewoodDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pinewood.Models.Customer> Customer { get; set; } = default!;
    }
}

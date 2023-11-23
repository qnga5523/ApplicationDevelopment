using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lap1.Models;

namespace Lap1.Data
{
    public class Lap1Context : DbContext
    {
        public Lap1Context (DbContextOptions<Lap1Context> options)
            : base(options)
        {
        }

        public DbSet<Lap1.Models.Ticket> Ticket { get; set; } = default!;
    }
}

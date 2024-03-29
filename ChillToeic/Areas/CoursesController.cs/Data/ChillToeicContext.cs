using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChillToeic.Models;

namespace ChillToeic.Data
{
    public class ChillToeicContext : DbContext
    {
        public ChillToeicContext (DbContextOptions<ChillToeicContext> options)
            : base(options)
        {
        }

        public DbSet<ChillToeic.Models.Course> Course { get; set; } = default!;
    }
}

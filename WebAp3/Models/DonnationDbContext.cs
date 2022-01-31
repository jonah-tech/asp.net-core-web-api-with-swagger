using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAp3.Models
{
    public class DonnationDbContext : DbContext
    {
        public DonnationDbContext(DbContextOptions<DonnationDbContext> options) : base(options)
        {

        }
        public DbSet<DCandidate> DCandidates { get; set; }
    }
}

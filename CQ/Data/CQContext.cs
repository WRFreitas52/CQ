using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CQ.Models;

namespace CQ.Data
{
    public class CQContext : DbContext
    {
        public CQContext (DbContextOptions<CQContext> options)
            : base(options)
        {
        }

        public DbSet<CQ.Models.Player> Player { get; set; }
    }
}

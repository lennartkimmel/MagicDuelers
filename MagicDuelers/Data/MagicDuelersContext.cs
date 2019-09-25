using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MagicDuelers.Models
{
    public class MagicDuelersContext : DbContext
    {
        public MagicDuelersContext (DbContextOptions<MagicDuelersContext> options)
            : base(options)
        {
        }

        public DbSet<MagicDuelers.Models.User> User { get; set; }
    }
}

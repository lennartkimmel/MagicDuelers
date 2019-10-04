using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MagicDuelers.Models;

namespace MagicDuelers.Models
{
    public class MagicDuelersProfileContext : DbContext
    {
        public MagicDuelersProfileContext (DbContextOptions<MagicDuelersProfileContext> options)
            : base(options)
        {
        }

        public DbSet<MagicDuelers.Models.Profile> Profile { get; set; }

        public DbSet<MagicDuelers.Models.Deck> Deck { get; set; }
    }
}

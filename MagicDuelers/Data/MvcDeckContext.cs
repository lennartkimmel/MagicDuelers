using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDeck.Models;

namespace MagicDuelers.Models
{
    public class MvcDeckContext : DbContext
    {
        public MvcDeckContext (DbContextOptions<MvcDeckContext> options)
            : base(options)
        {
        }

        public DbSet<MvcDeck.Models.Deck> Deck { get; set; }
    }
}

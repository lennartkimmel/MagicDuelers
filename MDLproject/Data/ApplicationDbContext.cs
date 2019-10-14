using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MDLproject.Models;

namespace MDLproject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Deck> Decks { get; set; }



        public DbSet<Format> Formats { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

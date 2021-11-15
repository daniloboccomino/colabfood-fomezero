using System;
using globalsolution.fomezero.Models;
using Microsoft.EntityFrameworkCore;

namespace globalsolution.fomezero.Persistence
{
    public class ColabfoodContext : DbContext
    {
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Charity> Charities { get; set; }
        public DbSet<Advertising> Advertisings { get; set; }
        public DbSet<Donation> Donations { get; set; }

        public ColabfoodContext(DbContextOptions op) : base(op)
        {
        }


    }
}

using homework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { }
        public DbSet<Jumborton> jumborton { get; set; }
        public DbSet<Counter> counters { get; set; }
        public DbSet<CounterItem> counterItems { get; set; }
        public DbSet<CounterItem> counterItems2 { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Portfolio> portfolios1 { get; set; }
        public DbSet<Category> categories1 { get; set; }
        public DbSet<Pricing> pricing { get; set; }
        public DbSet<Client> clients { get; set; }

    }
}

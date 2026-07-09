using Microsoft.EntityFrameworkCore;
using SMConsulting.Core;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.DAL.Context
{
    public class SmDbContext : DbContext
    {
        public SmDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users1 { get; set; }
        public DbSet<RefreshToken> RefreshTokens1 { get; set; }
        public DbSet<Applyment> Applyments1 { get; set; }
        public DbSet<Hero> Heros1 { get; set; }
        public DbSet<Contact> Contacts1 { get; set; }
        public DbSet<SocialMedia> SocialMedias1 { get; set; }
        public DbSet<About> Abouts1 { get; set; }
        public DbSet<Card> Cards1 { get; set; }
        public DbSet<Vision> Visions1 { get; set; }
        public DbSet<Value> Values1 { get; set; }
        public DbSet<Team> Teams1 { get; set; }
        public DbSet<Member> Members1 { get; set; }
        public DbSet<Blog> Blogs1 { get; set; }
        public DbSet<Partner> Partners1 { get; set; }
        public DbSet<Sector> Sectors1 { get; set; }
        public DbSet<Service> Services1 { get; set; }
        public DbSet<CardSpecification> CardSpecifications1 { get; set; }
        public DbSet<Training> Trainings1 { get; set; }
        public DbSet<SectorHelp> SectorHelps1 { get; set; }
        public DbSet<Difficulty> Difficulties1 { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users1");
            modelBuilder.Entity<RefreshToken>().ToTable("RefreshTokens1");
            modelBuilder.Entity<Applyment>().ToTable("Applyments1");
            modelBuilder.Entity<Hero>().ToTable("Heros1");
            modelBuilder.Entity<Contact>().ToTable("Contacts1");
            modelBuilder.Entity<SocialMedia>().ToTable("SocialMedias1");
            modelBuilder.Entity<About>().ToTable("Abouts1");
            modelBuilder.Entity<Card>().ToTable("Cards1");
            modelBuilder.Entity<Vision>().ToTable("Visions1");
            modelBuilder.Entity<Value>().ToTable("Values1");
            modelBuilder.Entity<Team>().ToTable("Teams1");
            modelBuilder.Entity<Member>().ToTable("Members1");
            modelBuilder.Entity<Blog>().ToTable("Blogs1");
            modelBuilder.Entity<Partner>().ToTable("Partners1");
            modelBuilder.Entity<Sector>().ToTable("Sectors1");
            modelBuilder.Entity<Service>().ToTable("Services1");
            modelBuilder.Entity<CardSpecification>().ToTable("CardSpecifications1");
            modelBuilder.Entity<Training>().ToTable("Trainings1");
            modelBuilder.Entity<SectorHelp>().ToTable("SectorHelps1");
            modelBuilder.Entity<Difficulty>().ToTable("Difficulties1");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SmDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProvidedService> ProvidedServices { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder
                .Entity<User>()
                .HasMany(u => u.UserSkills)
                .WithOne()
                .HasForeignKey(u => u.IdUser)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<UserSkill>()
                .HasKey(u => u.Id);

            modelBuilder
                .Entity<ProvidedService>()
                .HasKey(u => u.Id);

            modelBuilder
                .Entity<ProvidedService>()
                .HasOne(p => p.Freelancer)
                .WithMany(f => f.ProvidedServices)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<ProvidedService>()
                .HasOne(p => p.Client)
                .WithMany(f => f.OwningProvidedServices)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Skill>()
                .HasKey(u => u.Id);

            modelBuilder
                .Entity<Skill>()
                .HasMany(s => s.UserSkills)
                .WithOne()
                .HasForeignKey(s => s.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

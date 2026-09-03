using Krisestotte.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Krisestotte.Web.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Behov> Behov => Set<Behov>();
    public DbSet<Ressurs> Ressurser => Set<Ressurs>();
    public DbSet<Tildeling> Tildelinger => Set<Tildeling>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Behov>(entity =>
        {
            entity.Property(b => b.Latitude).HasPrecision(9, 6);
            entity.Property(b => b.Longitude).HasPrecision(9, 6);
            entity.HasOne(b => b.OpprettetAvUser)
                .WithMany()
                .HasForeignKey(b => b.OpprettetAvUserId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Ressurs>(entity =>
        {
            entity.Property(r => r.Latitude).HasPrecision(9, 6);
            entity.Property(r => r.Longitude).HasPrecision(9, 6);
            entity.HasOne(r => r.OpprettetAvUser)
                .WithMany()
                .HasForeignKey(r => r.OpprettetAvUserId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Tildeling>(entity =>
        {
            entity.HasOne(t => t.Behov)
                .WithMany()
                .HasForeignKey(t => t.BehovId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(t => t.Ressurs)
                .WithMany()
                .HasForeignKey(t => t.RessursId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(t => t.TildeltAvUser)
                .WithMany()
                .HasForeignKey(t => t.TildeltAvUserId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
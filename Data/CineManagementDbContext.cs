using System;
using System.Collections.Generic;
using CineProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Data;

public partial class CineManagementDbContext : DbContext
{
    public CineManagementDbContext()
    {
    }

    public CineManagementDbContext(DbContextOptions<CineManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Showtime> Showtimes { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bills__DED88B1CDB7B07B9");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__categori__DED88B1CE4312A84");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__items__DED88B1CE93A349C");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__movies__DED88B1C3C3319D6");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__rooms__DED88B1C4149DFE3");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__seats__DED88B1C7FFF96A0");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shifts__DED88B1CDB76CF60");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Showtime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__showtime__DED88B1CCC6FB94F");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tickets__DED88B1C06F015E9");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__DED88B1CC64B9C2B");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

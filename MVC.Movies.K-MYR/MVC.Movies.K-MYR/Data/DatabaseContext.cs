﻿using Microsoft.EntityFrameworkCore;

namespace MVC.Movies.K_MYR.Data;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<Models.Movie> Movies { get; set; }

    public DbSet<Models.TVShow> TVShows { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Movie>()
            .Property(m => m.Price)
            .HasPrecision(10,7);
    }
}

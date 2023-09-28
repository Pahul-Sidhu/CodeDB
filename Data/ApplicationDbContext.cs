using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityApp.Models;

namespace CommunityApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


    public DbSet<City>? Cities { get; set; }
    public DbSet<Province>? Players { get; set; }

    protected override void OnModelCreating(ModelBuilder builder){


    base.OnModelCreating(builder);

    builder.Entity<City>().ToTable("City");
        builder.Entity<Province>().ToTable("Province");

    builder.Seed();
} 
}

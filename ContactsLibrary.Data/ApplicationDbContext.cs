﻿using ContactsLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsLibrary.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ContentManager;Trusted_Connection=True;");
    }

    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                Id = 1, FirstName = "Smartechie", LastName = "Inc", Email = "mail2sudhir.online+smartechie@gmail.com",
                PhoneNumber = "1234567890"
            });
    }
}
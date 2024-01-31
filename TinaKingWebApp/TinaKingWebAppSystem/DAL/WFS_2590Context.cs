﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TinaKingSystem.Entities;

namespace TinaKingSystem.DAL
{
internal partial class WFS_2590Context : DbContext
{
    public WFS_2590Context(DbContextOptions<WFS_2590Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.Property(e => e.ClientID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.Property(e => e.DocumentID).ValueGeneratedNever();

            entity.HasOne(d => d.Client).WithMany(p => p.Documents).HasConstraintName("FK_Document_Client");

            entity.HasOne(d => d.Package).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Package");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.Property(e => e.PackageID).ValueGeneratedNever();

            entity.HasOne(d => d.Client).WithMany(p => p.Packages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Package_Client");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.Property(e => e.ReviewID).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.Reviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Review_Employee");

            entity.HasOne(d => d.Package).WithMany(p => p.Reviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Review_Package");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}
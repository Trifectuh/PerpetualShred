﻿using System;
using Microsoft.EntityFrameworkCore;

namespace ShredCrawl
{
    public sealed class PerpetualShredContext_0B395B8309F4411697C6Eb6C19F89Ae2Context : DbContext
    {
        public DbSet<WebVid> WebVid { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(@"Server=mi3-wsq3.a2hosting.com;Initial Catalog=perpetu1_shred;User ID=perpetu1_Trif3ctuh;Password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebVid>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });
        }
    }
}

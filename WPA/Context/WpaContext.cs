﻿using Microsoft.EntityFrameworkCore;

namespace BD_Kursach_WPF
{
    public class WpaContext : DbContext
    {
        public DbSet<ITObject> it_objects { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<Unit> units { get; set; }
        public DbSet<Position> positions { get; set; }
        public WpaContext(DbContextOptions opt) : base(opt)
        {
            Database.EnsureCreated();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class RepoPatternDemoEntities : DbContext
    {
        public RepoPatternDemoEntities() : base("RepoPatternDemoEntities") { }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<City> Cities { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HeroConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
        }
    }
}
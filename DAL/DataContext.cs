using Motivation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Motivation.DAL
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Models.Action> Actions { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Reward> Rewards { set; get; }
        public DbSet<Session> Sessions { set; get; }
        public DbSet<Issue> Issues { set; get; }

        public DataContext() : base("DefaultConnection")
        { }

    }
}
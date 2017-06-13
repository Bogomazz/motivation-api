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
        DbSet<User> Users { set; get; }
        DbSet<Models.Action> Actions { set; get; }
        DbSet<Category> Categories { set; get; }
        DbSet<Reward> Rewards { set; get; }
        DbSet<Session> Sessions { set; get; }
        DbSet<Task> Tasks { set; get; }

        public DataContext() : base("DefaultConnection")
        { }

    }
}
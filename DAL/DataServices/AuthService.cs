using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Motivation.Models;

namespace Motivation.DAL.DataServices
{
    public class AuthService : IDisposable
    {
        DataContext context;

        public AuthService()
        {
            context = new Motivation.DAL.DataContext();
        }
        public User GetUserByToken(string token)
        {
            return (from s in context.Sessions
                           from u in context.Users
                           where s.Token == token && u.Id == s.UserId
                           select u).FirstOrDefault();
        }

        public void Dispose() { }
    }
}
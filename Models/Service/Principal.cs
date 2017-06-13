using Motivation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Motivation.Models.Service
{
    public class Principal : IPrincipal
    {
        public Principal(IUser user)
        {
            this.Identity = new Identity(user);
        }
        public IIdentity Identity {get;}

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}
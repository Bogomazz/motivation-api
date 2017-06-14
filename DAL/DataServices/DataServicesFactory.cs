using Motivation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Motivation.DAL.DataServices
{
    public class DataServicesFactory
    {
        public static IDataService<T> CreateDataService<T>()
        {
            if(typeof(T) == typeof(Session))
            {
                return (IDataService<T>) new SessionsService();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
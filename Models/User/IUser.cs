using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivation.Models.Interfaces
{
    public interface IUser
    {
        string Name { set; get; }
        string Login { set; get; }
        
    }
}
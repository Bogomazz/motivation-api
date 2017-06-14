using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivation.DAL.DataServices
{
    public interface IDataService<T>
    {
        T Get();
        T Get(int id);
        void Edit(T newDataSet);
        void New(T newDataSet);
        void Delete(int id);
    }
}

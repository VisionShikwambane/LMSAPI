using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels
{
    public interface IMapToDomain<T> where T : class
    {
        int ID { get; }

        T toDomain();
    }
}

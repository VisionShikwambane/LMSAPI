using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataModels
{
    public interface IMapToDTO<TDTO>
    {
        TDTO toDTO();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorVOTOCMC1.Database.Abstract
{
    interface ICrud<T>
    {
        List<T> ListarTodos();
    }
}

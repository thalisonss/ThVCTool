using MonitorVOTOCMC1.Database.Entity;
using MonitorVOTOCMC1.Database.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace MonitorVOTOCMC1.Business
{
    class MC1WSLOGBusiness
    {
        MC1WSLOGDatabase _db = new MC1WSLOGDatabase();
        public List <MC1_WS_LOG> WSLOGQuantidadeRegistrosComErro(DateTime deData, DateTime ateData)
        {
            return _db.WSLOGQuantidadeRegistrosComErro(deData, ateData);
        }
    }
}

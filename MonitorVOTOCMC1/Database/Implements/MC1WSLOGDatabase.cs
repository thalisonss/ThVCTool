using MonitorVOTOCMC1.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace MonitorVOTOCMC1.Database.Implements
{
    class MC1WSLOGDatabase : MC1LOGWSBaseDB
    {
        public List<MC1_WS_LOG> WSLOGQuantidadeRegistrosComErro(DateTime deData, DateTime ateData)
        {

                    List<MC1_WS_LOG> logs = _db.MC1_WS_LOG.AsNoTracking()
                        .Where(x => x.dLog >= deData && x.dLog <= ateData && x.cType.Contains("erro"))
                        .ToList();

                    return logs;

        }

        public bool VerificarConexao()
        {
            try
            {
                var latestCustomer = _db.MC1_WS_LOG
                                .OrderByDescending(c => c.dLog)
                                .FirstOrDefault();

                if (latestCustomer != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}

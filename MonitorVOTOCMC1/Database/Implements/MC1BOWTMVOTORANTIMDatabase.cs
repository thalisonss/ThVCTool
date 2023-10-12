using MonitorVOTOCMC1.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorVOTOCMC1.Database.Implements
{
    class MC1BOWTMVOTORANTIMDatabase : MC1BOWTMVOTORANTIMBaseDB
    {
        public List<mc1_CustomerGCCExt> WSLOGQuantidadeRegistrosComErro(DateTime deData, string usuario, string customerPrincipal)
        {
            deData = deData.Date;

            DateTime ateData = deData.Date.AddHours(23)
                                          .AddMinutes(59)
                                          .AddSeconds(59)
                                          .AddMilliseconds(99);

            List<mc1_CustomerGCCExt> logs = _db.mc1_CustomerGCCExt.AsNoTracking()
                                                  .Where(x => x.mc1LastUpdate >= deData
                                                        && x.mc1LastUpdate <= ateData 
                                                        && x.cUser.Contains(usuario)
                                                        && x.cIDCustomerParent.Contains(customerPrincipal))
                                                   .ToList();

            return logs;
        }

        public bool VerificarConexao()
        {
            try
            {
                var latestCustomer = _db.mc1_CustomerGCCExt
                                .OrderByDescending(c => c.mc1LastUpdate)
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

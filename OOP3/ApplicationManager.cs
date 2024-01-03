using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplicationManager
    {
        //Method Injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credities)
        {
            foreach (var credit in credities)
            {
                credit.Hesapla();
            }
        }
    }
}

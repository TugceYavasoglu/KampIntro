using System;
using System.Collections.Generic;

namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
           
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(TransportCreditManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });


            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,transportCreditManager};

            //applicationManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}

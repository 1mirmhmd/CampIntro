using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplManager
    {
        // Method Injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices) // Çoklu işlem yapıldığında List yollanır
        {
            creditManager.Calc();
            foreach (var logger in loggerServices)
            {
                logger.Log();  
            }
        }
        public void CreditPreInform(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calc();
            }
        }
    }
}

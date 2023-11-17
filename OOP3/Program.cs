namespace OOP3
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MortgageManager mortgageManager = new MortgageManager();
            // Interface'ler de kendilerinden türetilen class'ların referanslarını tutabilirler
            ICreditManager consumerManager = new ConsumerCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();

            ILoggerService dbloggerService= new DbLoggerService();
            ILoggerService flloggerService= new FileLoggerService();

            ApplManager applManager = new ApplManager();
            applManager.Apply(mortgageManager, new List<ILoggerService> {new FileLoggerService(),new DbLoggerService(), new SmsLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager>() {consumerManager, vehicleCreditManager };
            //applManager.CreditPreInform(credits);
        }
    }
}

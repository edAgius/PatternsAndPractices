using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        /// 
        /// Adapter Design Pattern Demo
        /// 
        private partial class AdaptorService
        {
            public AdaptorService()
            {
                Adapt();
            }
            static void Adapt()
            {
                ITarget Itarget = new EmployeeAdapter();
                ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
                client.ShowEmployeeList();
            }
        }
    }
}
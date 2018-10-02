namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class FactoryService
        {
            private interface IFanFactory
            {
                IFan CreateFan(FanType type);
            }
        }
    }
}
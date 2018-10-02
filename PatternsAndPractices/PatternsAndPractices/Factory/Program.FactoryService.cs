namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class FactoryService
        {
            public FactoryService()
            {
                DoWork();
            }

            public void DoWork()
            {
                IFanFactory simpleFactory = new FanFactory();
                // Creation of a Fan using Simple Factory
                IFan fan = simpleFactory.CreateFan(FanType.TableFan);
                // Use created object
                fan.SwitchOn();

            }
        }
    }
}
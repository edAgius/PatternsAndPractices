namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class FactoryService
        {
            private class FanFactory : IFanFactory
            {
                public IFan CreateFan(FanType type)
                {
                    switch (type)
                    {
                        case FanType.TableFan:
                            return new TableFan();
                        case FanType.CeilingFan:
                            return new CeilingFan();
                        case FanType.ExhaustFan:
                            return new ExhaustFan();
                        default:
                            return new TableFan();
                    }
                }
            }
        }
    }
}
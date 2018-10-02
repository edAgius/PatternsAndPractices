namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            private class NameCardDecorator : Decorator
            {
                private int m_DiscountRate = 5;

                public NameCardDecorator(BakeryComponent baseComponent)
                    : base(baseComponent)
                {
                    this.name = "Name Card";
                    this.price = 4.0;
                }

                public string GetName()
                {
                    return base.name +
                           string.Format("\n(Please Collect your discount card for {0}%)",
                               m_DiscountRate);
                }
            }
        }
    }
}
namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            public abstract class Decorator: BakeryComponent
            {
                BakeryComponent BaseComponent = null;

                protected string name = "undefined decorator";

                protected double price = 0.0;

                protected Decorator(BakeryComponent basecomponent)
                {
                    BaseComponent = basecomponent;
                }
                string BakeryComponent.GetName()
                {
                    return string.Format("{0}, {1}", BaseComponent.GetName(), name);
                }

                double BakeryComponent.GetPrice()
                {
                    return price + BaseComponent.GetPrice();
                }
            }
        }
    }
}
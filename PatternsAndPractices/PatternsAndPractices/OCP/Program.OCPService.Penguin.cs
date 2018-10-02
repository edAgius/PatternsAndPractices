namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class Penguin : Bird
            {
                private ISwimming swim_;
                private IQuacking quack_;
                private IFlying fly_;
                public Penguin(ISwimming swim, IQuacking quack, IFlying fly)
                {
                    swim_ = swim;
                    quack_ = quack;
                    fly_ = fly;
                }

                public override void Fly()
                {
                    this.fly_.Fly();
                }
            }
        }
    }
}
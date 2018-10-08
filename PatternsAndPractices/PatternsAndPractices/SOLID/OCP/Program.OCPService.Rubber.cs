namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class Rubber : Duck
            {
                private ISwimming swim_;
                private IQuacking quack_;
                private IFlying fly_;
                public Rubber(ISwimming swim, IQuacking quack, IFlying fly)
                {
                    swim_ = swim;
                    quack_ = quack;
                    fly_ = fly;
                }

                public override void Quack()
                {
                    this.quack_.Quack();
                }

            }
        }
    }
}
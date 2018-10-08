using System.Security.Cryptography.X509Certificates;
using static PatternsAndPractices.Program.OCPService;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public OCPService()
            {
                Mallarrd m = new Mallarrd(new Swimming(), new QuackingDuck(), new Flying());
                m.Fly();
                m.Quack();
                m.Swim();
                m.Waddle();
                Rubber r = new Rubber(new Swimming(), new SqueakingDuck(), new Flying());
                r.Fly();
                r.Quack();
                r.Swim();
                r.Waddle();

                Penguin p = new Penguin(new Swimming(), new QuackingDuck(), new NoFly());
                p.Fly();
                p.Quack();
                p.Swim();
                p.Waddle();

                Eider e = new Eider(new Swimming(), new OoohDuck(), new Flying());
                e.Fly();
                e.Quack();
                e.Swim();
                e.Waddle();
            }
        }
    }

}
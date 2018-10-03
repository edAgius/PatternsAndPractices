using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PatternsAndPractices;
using Console = System.Console;

namespace PatternsAndPractices
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //SRP
            Console.WriteLine("SRP");
            UserStorage s = new UserStorage();
            EmailStorage e = new EmailStorage();

            SRPService main = new SRPService(s,e);
            Console.WriteLine("_________________________________");
            Console.WriteLine("OCP");
            //OCP
            OCPService ocp = new OCPService();
            Console.WriteLine("_________________________________");
            Console.WriteLine("LSP");
            //LSP
            LSPService lsp = new LSPService();
            Console.WriteLine("_________________________________");
            Console.WriteLine("ISP");
            //ISP
            ISPService isp = new ISPService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("DIP");
            //DIP
            DIPService sip = new DIPService();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Law of Demeter");
            //Law of demeter
            Demeter dim = new Demeter();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Factory pattern");
            //factory
            FactoryService factory = new FactoryService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("Adaptor Pattern");
            //Adaptor pattern
            AdaptorService adaptorService = new AdaptorService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("Decorator Pattern");
            //decorator pattern
            DecoratorService decoratorService = new DecoratorService();
            Console.WriteLine("_________________________________");


            Console.WriteLine("Repository Pattern");
            //Repository pattern
            RepositoryService RepositoryService = new RepositoryService();
            Console.WriteLine("_________________________________");


            Console.WriteLine("Tree Traversal");
            //BinaryTree Traversal
            BinaryTreeService BinaryTreeService = new BinaryTreeService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("Number Swap");
            //Number Swap
            NumberSwapService NumberSwapService = new NumberSwapService();
            Console.WriteLine("_________________________________");
            //read



            Console.ReadLine();
        }
    }
}




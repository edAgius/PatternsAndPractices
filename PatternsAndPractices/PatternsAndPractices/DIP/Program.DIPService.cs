using System.ComponentModel;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DIPService
        {
            public DIPService()
            {
                WorkService workService = new WorkService(new Logger(), new Storage(), new Combiner());
                workService.DoWork("ED");
                workService.DoWork("Tarnya");
            }
        }
    }
}
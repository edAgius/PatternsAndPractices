namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DIPService
        {
            public class WorkService
            {
                private ILogger Logger;
                private IStorage Storage;
                private ICombiner Combiner;

                public WorkService(ILogger logger, IStorage storage, ICombiner combiner)
                {
                    Logger = logger;
                    Storage = storage;
                    Combiner = combiner;
                }

                public void DoWork(string text)
                {
                    Logger.log(text);

                    var result = Combiner.Combine(text, text + "1");
                    Logger.log("result is " + result);


                    Storage.Save(result);
                    Logger.log("saved " + result);
                }
            }
        }
    }
}
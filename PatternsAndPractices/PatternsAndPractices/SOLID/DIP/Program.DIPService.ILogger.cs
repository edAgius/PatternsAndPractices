namespace PatternsAndPractices
{
    public partial class Program
    {
        public partial class DIPService
        {
            public interface ILogger
            {
                void log(string logText);
            }
        }
    }
}
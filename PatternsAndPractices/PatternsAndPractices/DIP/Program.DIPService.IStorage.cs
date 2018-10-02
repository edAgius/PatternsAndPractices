namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DIPService
        {
            public interface IStorage
            {
                void Save(string text);
            }
        }
    }
}
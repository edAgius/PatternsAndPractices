namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DIPService
        {
            public interface ICombiner
            {
                string Combine(string text1, string text2);
            }
        }
    }
}
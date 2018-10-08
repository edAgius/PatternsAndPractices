using System.Text;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DIPService
        {
            public class Combiner : ICombiner
            {
                public string Combine(string text1, string text2)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(text1);
                    sb.Append(text2);
                    return sb.ToString();
                }
            }
        }
    }
}
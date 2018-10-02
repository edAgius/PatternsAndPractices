using System.Collections.Generic;

namespace PatternsAndPractices
{
    partial class Program
    {
        private partial class AdaptorService
        {
            /// <summary>
            /// The 'ITarget' interface
            /// </summary>
            public interface ITarget
            {
                List<string> GetEmployeeList();
            }
        }
    }
}
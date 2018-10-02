using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class RepositoryService
        {
            public abstract class EntityBase
            {
                public Int64 Id { get; set; }
            }
        }
    }
}
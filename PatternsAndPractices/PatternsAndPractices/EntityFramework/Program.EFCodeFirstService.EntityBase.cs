using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class EFCodeFirstService
        {
            public abstract class EntityBase
            {
                public Int64 Id { get; set; }
            }
        }
    }
}
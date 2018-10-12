namespace Interview
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public interface IStoreable
    {
       IComparable Id { get; set; }

        string Description { get; set; }

        int StoreId { get; set; }

        int StoreKey { get; set; }
    }
}
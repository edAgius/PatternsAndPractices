namespace Interview
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Storeable : IStoreable, IComparable
    {
        private string description;
        private int storeId;
        private IComparable id;
        private int storeKey;

        public int StoreKey
        {
            get
            {
                return storeKey;
            }
            set
            {
                storeKey = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }


        public IComparable Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        [Key]
        public int StoreId
        {
            get
            {
                return storeId;
            }
            set
            {
                storeId = value;
            }
        }



        public int CompareTo(object obj)
        {
            return this.Id.CompareTo(((Storeable)obj).Id);
        }
    }
}
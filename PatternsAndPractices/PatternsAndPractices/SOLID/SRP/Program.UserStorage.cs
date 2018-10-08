using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public class UserStorage : IUserStorage
        {
            public void Save(User user)
            {
                Console.WriteLine("save " + user.Name);
            }

            public User CreateUser(string name)
            {
                User user = new User();
                user.Name = name;
                return user;
            }
        }
    }
}
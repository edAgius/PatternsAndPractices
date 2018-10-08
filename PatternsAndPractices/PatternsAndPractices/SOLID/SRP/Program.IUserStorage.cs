namespace PatternsAndPractices
{
    partial class Program
    {
        public interface IUserStorage
        {
            void Save(User user);
            User CreateUser(string name);
        }
    }
}
namespace PatternsAndPractices
{
    partial class Program
    {
        public class UserRegistration
        {
            private IUserStorage db_;
            private IEmailStorage email_;
            public UserRegistration(IUserStorage db, IEmailStorage email)
            {
                this.db_ = db;
                this.email_ = email;
            }

            public void Register(User user)
            {
                this.db_.Save(user);


                this.email_.Email(user);

            }





        }
    }
}
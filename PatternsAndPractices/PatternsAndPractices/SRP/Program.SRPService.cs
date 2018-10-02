using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public class  SRPService
        {
            private IUserStorage user_;
            private IEmailStorage email_;

            public SRPService(IUserStorage user, IEmailStorage email)
            {
                user_ = user;
                email_ = email;

                DoWork();
            }
            public void DoWork()
            {
                var newUser = user_.CreateUser("ed");


                UserRegistration r = new UserRegistration(user_, email_);
                r.Register(newUser);

            }
        }
    }
}
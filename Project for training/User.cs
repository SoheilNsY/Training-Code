using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_training
{
    public partial class User:Person,IUser// inja darim ers bari mikonim az Person va az gharar dad IUSER estefade mikonim
    {

        private string _username;
        protected string Email;

        public User(string email, string Username,string Fullname) : base(Fullname)
        {
            _username = Username;
            Email=email;

        }
         
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public override void Showinfo()
        {
            Console.WriteLine($"The full name is: {Fullname}");
            Console.WriteLine($"The Email is {Email}");
            Console.WriteLine($"the Username is: {_username}");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_training
{
    public class Admin : User
    {
        public string Role { get; set; }

        public Admin(string Fullname, string email, string Username,string role) : base( email,Username,Fullname)
        {
            Role=role;



        }

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine($"The Role is {Role}");
        }



    }
}

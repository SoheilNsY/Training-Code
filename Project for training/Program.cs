using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUser adminuser = new Admin("Soheil", "rezastar370@gmail.com,", "LoverBoy", "Admin");
            adminuser.Showinfo();
            Helper.Soperator();
            User normalUser = new User("Yagoo.com", "Holly", "Ali");
            
            normalUser.Showinfo();

            Console.ReadLine();

        }
    }
}

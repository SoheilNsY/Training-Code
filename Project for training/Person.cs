using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_training
{
    public abstract class Person// Class faghad baraye ers bari
    {
        protected string Fullname { get; set; }// Property 

        public Person(string fullname)//baraye estefade az class Person baiad azesh ye shey' besazi
        {
            Fullname = fullname;
        }

        public abstract void Showinfo();// in ham alan khalie vali bara method farzand mituni biarish va ettela'at ro barat chap kone
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    public class FullUser : User
    {
        public long Cnp { get; set; }
        public int Age { get; set; }
       public FullUser(long cnp, int age, string name, string lastname,string username,string password)
            :base(name,lastname,username,password)
        {
            Cnp = cnp;
            Age = age;
        }
    }
}

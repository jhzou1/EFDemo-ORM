using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFromDb
{
    class Program
    {
        static void Main(string[] args)
        {
            mydbentity mydbentity = new mydbentity();

            var student = mydbentity.Students.Find(100007);

            Console.Read();
        }
    }
}
